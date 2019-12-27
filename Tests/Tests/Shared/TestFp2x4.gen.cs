//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using NUnit.Framework;
using static Unity.Mathematics.FixedPoint.fpmath;
using static Unity.Mathematics.math;

namespace Unity.Mathematics.FixedPoint.Tests
{
    [TestFixture]
    public class TestFp2x4
    {
        public static void fp2x4_zero()
        {
            TestUtils.AreEqual(fp2x4.zero.c0.x, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c0.y, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c1.x, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c1.y, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c2.x, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c2.y, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c3.x, (fp)0);
            TestUtils.AreEqual(fp2x4.zero.c3.y, (fp)0);
        }

        public static void fp2x4_operator_equal_wide_wide()
        {
            fp2x4 a0 = fp2x4(-135.18924m, -49.0941162m, 169.129822m, 240.8053m, 314.7392m, 442.393m, 177.924438m, 335.5334m);
            fp2x4 b0 = fp2x4(-220.014648m, 66.98004m, 499.2016m, -371.1131m, 208.448669m, 390.8037m, -72.44382m, 362.97644m);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp2x4 a1 = fp2x4(168.15448m, 350.729553m, 367.178467m, 46.9414673m, 188.76416m, -97.2113953m, -293.320984m, -234.822937m);
            fp2x4 b1 = fp2x4(194.678345m, 471.644836m, -404.044678m, -144.696747m, -494.446655m, -252.970367m, 234.417114m, 398.724m);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp2x4 a2 = fp2x4(417.0337m, 26.3864136m, 269.245728m, 29.4741821m, 479.485229m, -237.230957m, -221.9837m, -506.672546m);
            fp2x4 b2 = fp2x4(260.4287m, 370.144226m, 89.579834m, -434.816833m, -109.845337m, 336.973022m, -409.154968m, 500.387573m);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp2x4 a3 = fp2x4(-22.98944m, 487.260864m, -419.731964m, 337.2033m, 245.043884m, 390.215881m, 84.4129639m, 434.2079m);
            fp2x4 b3 = fp2x4(-174.081818m, 395.101135m, 350.3393m, -243.144592m, -416.397369m, 151.576477m, -18.2243347m, -431.677917m);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        public static void fp2x4_operator_equal_wide_scalar()
        {
            fp2x4 a0 = fp2x4(65.6712m, 404.415527m, -269.730164m, 83.6306152m, 152.9945m, -155.868286m, 314.671265m, 386.365173m);
            fp b0 = (-155.815765m);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp2x4 a1 = fp2x4(290.04895m, -65.66748m, -69.68326m, -191.190765m, 186.845215m, -232.895691m, -319.144043m, -49.70108m);
            fp b1 = (-132.6352m);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp2x4 a2 = fp2x4(-300.8819m, 386.3775m, -296.7019m, -309.1172m, 141.542358m, -227.323334m, 83.87286m, -410.91687m);
            fp b2 = (333.396851m);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp2x4 a3 = fp2x4(110.501282m, 36.57434m, -427.541443m, -268.170837m, 175.8117m, -193.47995m, 291.051941m, 423.97168m);
            fp b3 = (-390.103577m);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        public static void fp2x4_operator_equal_scalar_wide()
        {
            fp a0 = (36.38391m);
            fp2x4 b0 = fp2x4(-400.4892m, -71.2868347m, 156.978088m, -225.238739m, 499.141785m, -211.979919m, 428.311951m, -489.501343m);
            bool2x4 r0 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            fp a1 = (-5.691559m);
            fp2x4 b1 = fp2x4(-30.8659363m, -362.9831m, 184.503174m, -160.470612m, 316.668823m, 390.369263m, 505.1051m, -294.6487m);
            bool2x4 r1 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            fp a2 = (443.1991m);
            fp2x4 b2 = fp2x4(96.5592651m, -257.012939m, -245.054962m, 326.464844m, -23.9599m, -168.694885m, 386.2486m, -227.090637m);
            bool2x4 r2 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            fp a3 = (-336.612427m);
            fp2x4 b3 = fp2x4(365.108154m, -405.390839m, -473.995483m, 298.435364m, -149.86322m, 450.0664m, 153.47644m, 56.28778m);
            bool2x4 r3 = bool2x4(false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        public static void fp2x4_operator_not_equal_wide_wide()
        {
            fp2x4 a0 = fp2x4(279.994141m, -43.34201m, -465.724731m, 317.466553m, 85.7149658m, 360.8905m, 366.081543m, 154.542847m);
            fp2x4 b0 = fp2x4(-460.9121m, -476.009033m, 468.1364m, -341.012543m, -62.65805m, -458.801666m, -457.730225m, -59.5232544m);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp2x4 a1 = fp2x4(332.4262m, 397.11322m, -431.374969m, 489.0108m, 398.4336m, -489.817932m, 171.4049m, -67.82968m);
            fp2x4 b1 = fp2x4(3.024231m, 155.812744m, -19.8399048m, -6.01693726m, -406.207916m, -102.420715m, -40.362915m, 452.6754m);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp2x4 a2 = fp2x4(-192.278717m, 227.84082m, 62.1381836m, 262.186462m, -404.0531m, 34.449585m, -204.795776m, -285.4118m);
            fp2x4 b2 = fp2x4(93.25757m, -258.378052m, -184.0498m, -379.2353m, -370.687317m, -255.947235m, 29.0557861m, 322.407654m);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp2x4 a3 = fp2x4(-72.20682m, 444.749268m, 238.81781m, 365.1801m, -437.9229m, -362.442627m, 445.954346m, -0.417480469m);
            fp2x4 b3 = fp2x4(415.071716m, -467.726135m, -433.784668m, -212.165924m, 474.674927m, 452.483215m, -92.11273m, -385.9221m);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        public static void fp2x4_operator_not_equal_wide_scalar()
        {
            fp2x4 a0 = fp2x4(-155.4411m, -19.4266052m, 174.633057m, 507.920715m, 59.177063m, 171.151489m, -58.92328m, -398.176849m);
            fp b0 = (-393.413544m);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp2x4 a1 = fp2x4(492.20105m, 270.341m, -380.243256m, 501.899048m, -134.345459m, 458.400452m, 46.7709961m, 161.459961m);
            fp b1 = (-165.241516m);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp2x4 a2 = fp2x4(261.514221m, -0.449920654m, 350.461426m, 202.221008m, 242.664m, 382.677063m, -468.967957m, -497.459473m);
            fp b2 = (-145.6124m);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp2x4 a3 = fp2x4(-80.93225m, -506.490326m, 449.348145m, 210.771m, 249.181824m, -338.468536m, 229.670654m, -76.5433044m);
            fp b3 = (-328.587769m);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        public static void fp2x4_operator_not_equal_scalar_wide()
        {
            fp a0 = (478.353149m);
            fp2x4 b0 = fp2x4(459.553223m, 436.453247m, -488.714172m, 392.767944m, -266.736633m, 338.557861m, -338.100128m, -152.314545m);
            bool2x4 r0 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            fp a1 = (-452.820679m);
            fp2x4 b1 = fp2x4(209.439331m, 50.10797m, 372.4344m, -488.0213m, 489.740784m, 270.4001m, -472.846771m, -286.850464m);
            bool2x4 r1 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            fp a2 = (-384.691864m);
            fp2x4 b2 = fp2x4(443.423523m, 358.7472m, -15.4140625m, -342.179169m, 468.967529m, -130.568085m, 401.785828m, -268.352264m);
            bool2x4 r2 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            fp a3 = (-239.231018m);
            fp2x4 b3 = fp2x4(411.386536m, 139.769348m, 334.522034m, -223.629242m, -12.4884644m, 113.468872m, -189.652252m, -212.846558m);
            bool2x4 r3 = bool2x4(true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }


    }
}
