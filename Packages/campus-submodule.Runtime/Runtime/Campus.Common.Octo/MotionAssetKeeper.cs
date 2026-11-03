namespace Campus.Common.Octo
{
    using global::Campus.Common.Octo;
    using global::VL;
    using global::VL.Animation;

    public class MotionAssetKeeper : CampusAssetKeeperBase<MotionDefine>
    {
        public ClipParam CreatePlayerParam()
        {
            return null;
        }

        public static implicit operator ClipParam(MotionAssetKeeper self)
        {
            return null;
        }

        public MotionAssetKeeper()
        {
        }
    }
}
