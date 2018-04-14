using DoAnTotNghiep.PresentationLayer;
using DoAnTotNghiep.BusinessLayer;
using DoAnTotNghiep.DataAcessLayer;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using DoAnTotNghiep;

namespace Unit_Test
{
    
    
    /// <summary>
    ///This is a test class for DangNhapTest and is intended
    ///to contain all DangNhapTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DangNhapTest
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
        ///Test Đang Nhập Thành Công - Với dữ liệu đúng
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DoAnTotNghiep.exe")]
        public void btnDongY_ClickTest()
        {
            DangNhap_Accessor target = new DangNhap_Accessor(); 
            target.txtMa.Text = "admin";
            target.txtMatKhau.Text = "123";

            Boolean expected = true;

            object sender = null; 
            EventArgs e = null; 
            target.btnDongY_Click(sender, e);
            Assert.AreEqual(expected, PhamMem.codangnhap);
        }

        /// <summary>
        ///Test Đang Nhập Thành Công - Với dữ liệu Sai UserName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DoAnTotNghiep.exe")]
        public void btnDongY_ClickTest_ErrorUserName()
        {
            DangNhap_Accessor target = new DangNhap_Accessor();
            target.txtMa.Text = "Admin123";
            target.txtMatKhau.Text = "123";

            Boolean expected = false;

            object sender = null;
            EventArgs e = null;
            target.btnDongY_Click(sender, e);
            Assert.AreEqual(expected, PhamMem.codangnhap);
        }

        /// <summary>
        ///Test Đang Nhập Thành Công - Với dữ liệu Sai Password
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DoAnTotNghiep.exe")]
        public void btnDongY_ClickTest_ErrorPass()
        {
            DangNhap_Accessor target = new DangNhap_Accessor();
            target.txtMa.Text = "Admin";
            target.txtMatKhau.Text = "123456";

            Boolean expected = true;

            object sender = null;
            EventArgs e = null;
            target.btnDongY_Click(sender, e);
            Assert.AreEqual(expected, PhamMem.codangnhap);
        }

        /// <summary>
        ///Test Đang Nhập Thành Công - Không Nhập UserName
        ///</summary>
        [TestMethod()]
        [DeploymentItem("DoAnTotNghiep.exe")]
        public void btnDongY_ClickTest_Error_Empty_UserName()
        {
            DangNhap_Accessor target = new DangNhap_Accessor();
            target.txtMa.Text = "";
            target.txtMatKhau.Text = "123";

            String expected = "Mã đăng nhập sai, vui lòng nhập lại";

            object sender = null;
            EventArgs e = null;
            target.btnDongY_Click(sender, e);
            Assert.AreEqual(expected, target.lbthongbao.Text);
        }
      
    }
}
