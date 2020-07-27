// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using BooksWagon.Pages;
using BrowserStackBooksWagon.Base;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserStackBooksWagon
{
    [TestFixture]
    public class TestClass : BaseClass
    {
        [Test,Order(1)]        
        public void LoginPageTest()
        {
               
                LoginPage login = new LoginPage(driver);
                login.AccountLogin();                
                //Validation
                string expectedPageTitle = "Online Bookstore | Buy Books Online | Read Books Online";
                string actualPageTitle = driver.Title;
                Assert.AreEqual(expectedPageTitle, actualPageTitle);          
        }

        [Test,Order(2)]        
        public void HomePageTest()
        {
                HomePage home = new HomePage(driver);
                home.SelectAnyBook();                
                //Validation
                string expectedPageUrl = "https://www.bookswagon.com/book/landmark-judgments-that-changed-india/9788129135087";
                string actualPageUrl = driver.Url;
                Assert.AreEqual(expectedPageUrl, actualPageUrl);
        }

        [Test,Order(3)]
        public void BookCartFrameTest()
        {
                BookCartFrame cart = new BookCartFrame(driver);
                cart.CartFrame();               
               // Validation
               // string expectedPageUrl = "https://www.bookswagon.com/book/landmark-judgments-that-changed-india/9788129135087";
               // string actualPageUrl = driver.Url;
               // Assert.AreEqual(expectedPageUrl, actualPageUrl);           
        }

        [Test,Order(4)]
        public void ShippingAddTest()
        {
                ShippingAdd ship = new ShippingAdd(driver);
                ship.AddressInfo();                
                //Validation
                string expectedPageUrl = "https://www.bookswagon.com/viewshoppingcart.aspx";
                string actualPageUrl = driver.Url;
                Assert.AreEqual(expectedPageUrl, actualPageUrl);          
        }

        [Test,Order(5)]
        public void ReviewOrderTest()
        {         
                ReviewOrder review = new ReviewOrder(driver);
                review.ReviewAndSave();                 
                //Validation
                Assert.IsTrue(driver.FindElement(By.Id("ctl00_phBody_SignIn_btnLogin")).Displayed);          
        }        
    }
}
