# Playback geometry measurements

`measure_poses.py` consumes the host's saved JSONL recording. It does not create a scene, run a solver, invoke native game methods, or assert expected results.

For each completed recorded frame, it reconstructs the six matching thigh shapes (left/right UpLeg capsules and two left/right knee-to-hip Line capsules) in world space from the final bone transforms and the actual job collider's scaled local geometry. Line endpoint shortening uses the recorded authored offsets. Capsule half-heights remain signed. It considers dynamic skirt spheres with a dynamic parent, excludes unused root collider fields, and requires an intersecting collision mask.

For sphere centre p and static axis a..b, t = clamp(dot(p-a,b-a)/dot(b-a,b-a),0,1). Static radius is (1-t)*rA + t*rB. Joint-centre penetration is max(0, staticRadius - distance(p,a+t*(b-a))); sphere overlap includes the dynamic sphere radius too. All skirt sphere offsets in this costume are zero, so sphere centres are the recorded skirt joints. Maxima cover short and long skirt rows and both legs. CSV names distinguish the worst sphere pair from the worst centre pair. `pairs_inside` counts sphere pairs deeper than 1 mm.

Leg lift angle is the angle of the observed hip-to-knee vector from world down. It identifies leg-raise moments, not a Humanoid muscle value. `dynamic_hits` and `skirt_chain_hits` copy the job's last-step collision counts for skirt entries. Initial full-baseline recording predates the explicit chain-count field; its chain-count cells are blank.

These are collision-proxy measurements, not a mesh-triangle intersection count. DMM provides video, not bone/collider telemetry, so no DMM penetration number is claimed. The original solver's projection and angle limits can retain small sphere overlaps even when joint centres are outside.

Full-playback scans use the ordinary Linux frame clock (usually clamped to 0.1 s). Focused pairs use Unity's capture clock at 60 simulation frames/s and sample approximately every 0.1 s. Each pair has identical start/stop times and actual sample timestamps. The paired baseline uses the original managed ActorAnimation.Runtime.dll **and** original lib_burst_generated.so, with the final host recorder. The first incorrectly configured pairs shared the new Burst library and are archived only under `.recon/task-l/shared-burst-captures`; they are excluded from all committed measurements.
