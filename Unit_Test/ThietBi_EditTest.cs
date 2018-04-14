using DoAnTotNghiep.PresentationLayer;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Unit_Test
{
    
    
    /// <summary>
    ///This is a test class for ThietBi_EditTest and is intended
    ///to contain all ThietBi_EditTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ThietBi_EditTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///Test Case cho trường hợp nhập đủ - Thêm Mới
        ///</summary>
        //[TestMethod()]
        //[DeploymentItem("DoAnTotNghiep.exe")]
        //public void btnluu_ClickTest_New_Full()
        //{
        //    ThietBi_Edit_Accessor target = new ThietBi_Edit_Accessor(); // TODO: Initialize to an appropriate value
        //    target.thietbi.MaThietBi = "M001";
        //    target.thietbi.TenTB = "Laptop Dell";
        //    target.thietbi.LoaiTBID = 1;
        //    target.thietbi.DVTID = 2;
        //    target.thietbi.NUOCSXID = 4;
        //    target.thietbi.NamSanXuat = 2007;
        //    target.thietbi.ThoiGianBH = 24;
        //    target.thietbi.SoLuongTB = 1;
        //    target.thietbi.ThongSoKT = "RAM 8 GB";
        //    target.thietbi.MoTa = "May mơi 100%";
        //    target.thietbi.HinhAnh = "Winter_01.jpg";

        //    string expected = "Thêm thành công";

        //    object sender = null; // TODO: Initialize to an appropriate value
        //    EventArgs e = null; // TODO: Initialize to an appropriate value
        //    target.btnluu_Click(sender, e);
        //    //Assert.AreEqual(expected,target);
        //}

        [TestMethod()]
        [DeploymentItem("DoAnTotNghiep.exe")]
        [ExpectedException(typeof(CapNhatThietBiException))]
        public void btnluu_ClickTest_ErrorMaTB()
        {
            ThietBi_Edit_Accessor target = new ThietBi_Edit_Accessor(); // TODO: Initialize to an appropriate value
            target.thietbi.MaThietBi = "";
            target.thietbi.TenTB = "Laptop Dell";
            target.thietbi.LoaiTBID = 1;
            target.thietbi.DVTID = 2;
            target.thietbi.NUOCSXID = 4;
            target.thietbi.NamSanXuat = 2007;
            target.thietbi.ThoiGianBH = 24;
            target.thietbi.SoLuongTB = 1;
            target.thietbi.ThongSoKT = "RAM 8 GB";
            target.thietbi.MoTa = "May mơi 100%";
            target.thietbi.HinhAnh = "Winter_01.jpg";

            string expected = "Mã thiết bị bị rỗng";

            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.btnluu_Click(sender, e);
            //Assert.AreEqual(expected, CapNhatThietBiException_Accessor.);
        }
    }
}
