"""Measure saved playback geometry only; this script never evaluates the simulation.
Usage: python3 measure_poses.py recording.jsonl measurements.csv
Distances are axis-nearest tapered-capsule overlaps in metres, reported in millimetres.
"""
import json,sys,csv,math
import numpy as np
from scipy.spatial.transform import Rotation

def vec(d):return np.array([d[k] for k in 'xyz'])
def rot(d):return Rotation.from_quat([d[k] for k in 'xyzw'])
def gap(p,a,b,ra,rb,r):
 axis=b-a; length=np.dot(axis,axis)
 t=np.clip(np.dot(p-a,axis)/length,0,1) if length else 0
 return np.linalg.norm(p-a-axis*t)-(ra*(1-t)+rb*t+r)
rows=[]
for line in open(sys.argv[1]):
 try:d=json.loads(line)
 except json.JSONDecodeError:continue
 ts={t['name']:t for t in d['transforms']};caps=[]
 for s in d['statics']:
  if s['name'] not in ['LeftUpLeg','RightUpLeg','LeftLeg','RightLeg']:continue
  t=ts[s['name']];c=s['collider'];q=rot(t['rotation']);p=vec(t['position'])
  if c['type']==1:a=p+q.apply(vec(c['float3_A']));b=p+q.apply(vec(c['float3_B']))
  elif c['type']==2:
   a=p.copy();b=vec(ts[s['name'].replace('Leg','UpLeg')]['position']);axis=b-a;length=np.linalg.norm(axis)
   if length>.01:
    a+=axis/length*max(0,c['float3_A']['x'])*c['scale'];b-=axis/length*max(0,c['float3_A']['y'])*c['scale']
  else:continue
  caps.append((s['name'],a,b,c))
 penetrations=[];centers=[];hits=0
 for i,b in enumerate(d['dynamics']):
  if 'Skirt' not in b['name'] or b['parent']<0:continue
  p=vec(ts[b['name']]['position']);c=b['collider'];parent=d['dynamics'][b['parent']]
  if c['type']==0:p+=rot(ts[parent['name']]['rotation']).apply(vec(c['float3_A']))
  else:continue
  hits+=b['hits']
  for name,a,z,s in caps:
   if not c['collisionMask']&s['collisionMask']:continue
   g=gap(p,a,z,s['float_A'],s['float_B'],c['float_A'])
   penetrations.append((max(0,-g),b['name'],name));centers.append((max(0,-g-c['float_A']),b['name'],name))
 worst=max(penetrations,default=(0,'',''))
 center=max(centers,default=(0,'',''))
 chain_hits=sum(d['chainHits'][i] for i,c in enumerate(d['chains']) if 'Skirt' in d['dynamics'][c['dynamicBoneIndex']]['name']) if 'chainHits' in d else None
 # Leg elevation above vertically down, independent of actor stage facing.
 angles=[]
 for side in ['Left','Right']:
  axis=vec(ts[side+'Leg']['position'])-vec(ts[side+'UpLeg']['position'])
  angles.append(math.degrees(math.acos(np.clip(-axis[1]/np.linalg.norm(axis),-1,1))))
 rows.append(dict(time=d['time'],dt=d['deltaTime'],left_angle=angles[0],right_angle=angles[1],max_sphere_penetration_mm=worst[0]*1000,max_center_penetration_mm=center[0]*1000,pairs_inside=sum(p[0]>0.001 for p in penetrations),worst_sphere_bone=worst[1] if worst[0] else '',worst_sphere_static=worst[2] if worst[0] else '',worst_center_bone=center[1] if center[0] else '',worst_center_static=center[2] if center[0] else '',dynamic_hits=hits,skirt_chain_hits=chain_hits))
with open(sys.argv[2],'w') as f:
 w=csv.DictWriter(f,fieldnames=rows[0],lineterminator='\n');w.writeheader();w.writerows(rows)
print('samples',len(rows),'last',rows[-1]['time'])
for r in sorted(rows,key=lambda r:max(r['left_angle'],r['right_angle']),reverse=True)[:8]:print(r)
