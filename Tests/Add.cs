// <copyright file='CommonPage.cs' company='symplr'>
// Copyright © 2024 symplr.  All rights reserved.  Confidential and Proprietary.
// </copyright>

namespace ObjectRepository.PageObjects.Common
{
    using OpenQA.Selenium;
    using Testing.Framework.Tools.BrowserAutomation;
    using System.Linq;
    using System;
    using ObjectRepository.PageObjects.Base;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;
    using System.Text.RegularExpressions;

    public class CommonPage : BasePage
    {

        #region Contructors

        public CommonPage(Driver driver) : base(driver)
        {
        }

        #endregion

        #region Properties

        protected override By PageLoadElement
        {
            get
            {
                return By.XPath("//*[@class='sympl-header-logo']");
            }
        }

        public static string LabelElementPartialXpath
        {
            get
            {
                return "//label[normalize-space()='{0}']";
            }
        }
        public static string CheckboxElementPartialXpath
        {
            get
            {
                return "//label[normalize-space()='{0}']/preceding-sibling::input";
            }
        }

        public string ToggleStatusXPath
        {
            get
            {
                return "//span[@class='sympl-toggle-slider']/following::label[text()='{0}']";
            }
        }

        public string ToggleXpath
        {
            get
            {
                return "//span[@class='sympl-toggle-slider']";
            }
        }

        public string CancelButtonXPath
        {
            get
            {
                return "//section[@class='section-container flex-button pt-3']//sympl-secondary-button[@text='{0}']";
            }
        }

        public string XpathForAllCheckBoxes
        {
            get
            {
                return "//sympl-data-grid[@id='data-grid-panel']//input[@class='sympl-input']";
            }
        }
        private string PageTitleXPath
        {
            get
            {
                return "//div/h6[@class='title' and contains(text(),'{0}')]";
            }
        }

        private string PageSubTitleXPath
        {
            get
            {
                return "//p[text()=' {0} ']";
            }
        }
        private string TableDataTextXpath
        {
            get
            {
                return "//td[contains(text(),'{0}')]";
            }
        }

        protected string PartialFieldNameXPath
        {
            get
            {
                return "//*[@label='{0}']";
            }
        }
        public By CancelBtnPopup
        {
            get
            {
                return By.XPath("//section[contains(@class,'section-container flex-button')]//button[contains(text(),'Cancel')]");
            }
        }
        protected string ToggleStateXpath
        {
            get
            {
                return "//label[@class='sympl-toggle-text']";
            }
        }

        protected string EntityButtonPartialXPath
        {
            get
            {
                return "//button[contains(.,'Add new entity logo')]";
            }
        }

        public string DocumentCloseIcon
        {
            get
            {
                return "//span[contains(text(),'{0}')]/parent::div/following::div/i";
            }
        }

        private By FileUpload
        {
            get
            {
                return By.XPath("//input[contains(@type, 'file')]");
            }
        }

        protected string NewLogoConfigurationPartialXPath
        {
            get
            {
                return "//button[contains(.,'Add new logo configuration')]";
            }
        }
        protected By LogoThumbnailCssSelector
        {
            get
            {
                return By.CssSelector("td img[alt='Logo']");
            }
        }

        protected string LogoUploadDateXpath
        {
            get
            {
                return "//th[text()=' {1} ']/ancestor::table//td[text()=' {0} ']";
            }
        }

        private string ViewEntityLogoButtonXpath
        {
            get
            {
                return "//div//footer//button[text()='{0}']";
            }
        }

        private string SelectProcessXPath
        {
            get
            {
                return "//div[@class='p-checkbox-box p-component'] | //div[@role='checkbox']";
            }
        }

        private string PrivilegesTabsXpath
        {
            get
            {
                return "//div[@class='sympl-tabs-header']//button[text()='{0}']";
            }
        }

        private string PrivilegesdocumentXpath
        {
            get
            {
                return "//td[@class='ng-star-inserted']//sympl-tooltip";
            }
        }

        private string TableXpath
        {
            get
            {
                return "//p-table[@class='p-element']";
            }
        }

        private string ScrollableElementXpath
        {
            get
            {
                return "//div[@class='p-datatable-wrapper']";
            }
        }

        private string TablePaginatorXpath
        {
            get
            {
                return "//p-paginator[@class='p-element ng-star-inserted']";
            }
        }

        private string FooterLogoXpath
        {
            get
            {
                return "//img[@alt='symplr logo']";
            }
        }

        private string FooterTextXpath
        {
            get
            {
                return "//span[text()='{0}']";
            }
        }

        private string PageHeadingXPath
        {
            get
            {
                return "//div/h6[contains(text(),'{0}')]";
            }
        }

        private string SortingOptionXPath
        {
            get
            {
                return "//th[text()=' {0} ']/p-sorticon";
            }
        }

        private string FilterOptionXPath
        {
            get
            {
                return "//th[text()=' {0} ']/p-columnfilter";
            }
        }
        protected string ScrollBarElement
        {
            get
            {
                return "//div[contains(@class,'pdf-viewer-container')]";
            }
        }
        private string FilterCheckboxXpath
        {
            get
            {
                return "//label[contains(text(), '{0}')]/parent::div/input[@type='checkbox']";
            }
        }

        private string LabelPartialXpath
        {
            get
            {
                return "//label[contains(text(),'{0}')]";
            }
        }

        private string PaginationNextButtonXpath
        {
            get
            {
                return "//p-paginator[@class='p-element ng-star-inserted']//button[@aria-label='Next Page']";
            }
        }

        private string EntitiesTableXpath
        {
            get
            {
                return "//td[count(../preceding-sibling::tr[1]//th[normalize-space(.)='Entity name']/preceding-sibling::th)+2]";
            }
        }

        private string PopUpCloseButtonXpath
        {
            get
            {
                return "//footer//button[contains(.,'{0}')]";
            }
        }

        private string ScrollableDocumentSectionXpath
        {
            get
            {
                return "//div[@class='document-card-container']";
            }
        }

        private string DocumentsNameXpath
        {
            get
            {
                return "//sympl-card-header[text()=' {0} ']";
            }
        }

        protected String SelectRecordPartialXpath
        {
            get
            {
                return ("//tr[{0}]/td[1]//div[@role=\"checkbox\"] | //div[@class='p-checkbox-box p-component']");
            }
        }

        protected string ReadOnlyXPath
        {
            get
            {
                return "//div[@class='sympl-input-field--wrapper sympl-input-field--wrapper--readonly']//input";
            }
        }

        private string ReadValueXpath
        {
            get
            {
                return "(//td[@class='ng-star-inserted']//sympl-callout[@class='sympl-tooltip hydrated'])[3]";
            }
        }

        private By ReturnToDashBoardXPath
        {
            get
            {
                return this.GetBy("//button[contains(text(),'Return to dashboard') or contains(text(),'Return to Dashboard')]");
            }
        }

        private By WebformDisplayNameXpath
        {
            get
            {
                return By.XPath("//div/h6[@class='title']");
            }
        }

        private string DownloadACopyXpath
        {
            get
            {
                return "//div[text()= '{0}']/following-sibling::div//a";
            }
        }

        private string DropdownXpath
        {
            get
            {
                return "//input[ @class='sympl-dropdown-input' and @placeholder='Select']";
            }
        }

        private string FromMyDocumentLibrarXpath
        {
            get
            {
                return "//div[contains(@class, 'sympl-dropdown-item-container')]//span[text()='{0}']";
            }
        }

        private By SelectFirstDocumentXpath
        {
            get
            {
                return By.XPath("//div[@class='sympl-grid image-grid ng-star-inserted']//sympl-card");
            }
        }

        private string AttachButtonXpath
        {
            get
            {
                return "//button[@class='primary-btn-sm' and @type='button' and text()='{0}']";

            }
        }

        private string DeleteIconXpath
        {
            get
            {
                return "//*[contains(.,'{0}')]//following-sibling::*//i[@class='si-sm si-trash-2']";
            }
        }

        private string FormOkButton
        {
            get
            {
                return "//button[text()='Ok']";
            }
        }

        protected string FileExceedsLimitXPath
        {
            get
            {
                return "//div[contains(@class,'error-message')]/span[text()='File size exceeds 10MB']";
            }
        }

        private string EntitiesListedInEntitySwitcherXpath
        {
            get
            {
                return "//select[@class='entities-list']/option";
            }
        }

        private string EntityDropdownXpath
        {
            get
            {
                return "//input[@placeholder='Select Entity']";
            }
        }

        private string EntitiesListedInEntityDropdownXpath
        {
            get
            {
                return "//div[@class='sympl-callout-content']/div[@role='group']//span";
            }
        }

        private string SelectPagePartialXpath
        {
            get
            {
                return "//div[contains(@class,'p-paginator-bottom')]/child::button[contains(@class,'p-paginator-{0}')]";
            }
        }

        private string TotalPagesXpath
        {
            get
            {
                return "//span[@class='p-paginator-pages ng-star-inserted']/child::button";
            }
        }

        public string SignaturePadXpath
        {
            get
            {
                return "//p[@class='signature_label']/following-sibling::canvas";
            }
        }

        public string TextareaXpath
        {
            get
            {
                return "//textarea[@id='sympl-textarea-0']";
            }
        }

        private By AllCheckboxesXpath
        {
            get
            {
                return By.XPath("//tbody[@role='rowgroup']//p-tablecheckbox");
            }
        }

        private By SingleCheckboxXpath
        {
            get
            {
                return By.XPath(".//input[@type='checkbox']");
            }
        }

        private By StandarPrivilegeTableXpath
        {
            get
            {
                return By.XPath("//table/tbody/tr");
            }
        }

        private By TableStatusXpath
        {
            get
            {
                return By.XPath("./td[5]");
            }
        }

        private By TableViewMoreLinkXpath
        {
            get
            {
                return By.XPath(".//td[last()]");
            }
        }

        private string LinkTextPartialXpath
        {
            get
            {
                return "//a[normalize-space()='{0}']";
            }
        }

        public string SelectPriviledgeFormPartialXpath
        {
            get
            {
                return "//td[text()=' {0} ']/preceding-sibling::td/child::p-tablecheckbox[@data-p-highlight='true']";
            }
        }

        public string PriviledgeFormValuesXpath
        {
            get
            {
                return "//tbody[@class='p-element p-datatable-tbody']/descendant::td";
            }
        }

        private string RequestFormPageXpath
        {
            get
            {
                return "//html[@lang='en']";
            }
        }

        private string CanvasXpath
        {
            get
            {
                return "//canvas";
            }
        }

        private string TableNameXpath
        {
            get
            {
                return "//div[@role='tablist']/button[contains(text(),'{0}')]";
            }
        }

        private string PopupButtonPartialXpath
        {
            get
            {
                return "//button[@class='primary-btn-sm'  and text()='{0}']";
            }
        }

        private string SelectRecordXpath
        {
            get
            {
                return "//tr[@class='p-element p-selectable-row ng-star-inserted']";
            }
        }

        private string EditAdminEntityPartialXpath
        {
            get
            {
                return "//td[text()=' {0} ']/following-sibling::td/descendant::button[text()='Edit']";
            }
        }

        private string DocuSignStatusXpath
        {
            get
            {
                return "//h6[text()='DocuSign configuration']/following::span[@class='sympl-toggle-slider']";
            }
        }

        private string PaginationDropdownXpath
        {
            get
            {
                return "//p-dropdown//div[@class='p-dropdown-trigger']";
            }
        }

        private string PaginationDropdownValuesXpath
        {
            get
            {
                return "//p-dropdownitem//span[@class='ng-star-inserted']";
            }
        }

        private string PaginationDropdownDefaultValueXpath
        {
            get
            {
                return "//p-dropdown//span[text()='{0}']";
            }
        }

        private string PaginationPagesPartialXpath
        {
            get
            {
                return "//span[contains(@class,'p-paginator-pages')]/button[contains(text(),'{0}')]";
            }
        }

        private string CurrentPagePartialXpath
        {
            get
            {
                return "//button[@aria-current='page'][contains(text(),'{0}')]";
            }
        }

        private string IconWithStepNumberXpath
        {
            get
            {
                return "//div[text()='{0}']//ancestor::a[@class='sympl-step-link']//i[contains(@class,'{1}')]";
            }
        }

        private string ButtonXpath
        {
            get
            {
                return "//sympl-primary-button//button[contains(text(),'{0}')]";
            }
        }

        private string LogoPartialXpath
        {
            get
            {
                return "//sympl-card-actions[@title='{0}']/parent::button";
            }
        }

        private string FieldValuePartialXpath
        {
            get
            {
                return "//input[@placeholder='{0}']";
            }
        }

        private string JsonFileNameXpath
        {
            get
            {
                return "//span[@class='file-name download-file']";
            }
        }

        private string EditPopupCloseButtonXpath
        {
            get
            {
                return "//span[contains(text(),'Edit')]/following-sibling::div/button";
            }
        }

        private string JsonFileRemoveButtonXpath
        {
            get
            {
                return "//div/i[@class='si-x si-sm']";
            }
        }

        private string ScrollablePopupXpath
        {
            get
            {
                return "//section[@class='form-container']";
            }
        }

        private string TableRowXpath
        {
            get
            {
                return "//tbody/tr";
            }
        }

        private string RadioButtonPartialXpath
        {
            get
            {
                return "//input[@class='sympl-radio-group-button'][@value='{0}']";
            }
        }

        private string PlaceholderPartialXpath
        {
            get
            {
                return "//input[@placeholder='{0}']";
            }
        }


        protected string ExpandAllLink
        {
            get
            {
                return "//div[@class='expandlink text-font-lg ng-star-inserted' ]//a[text()='{0}']";
            }
        }

        private string SelectDropDownButtonPartialXPath
        {
            get
            {
                return "//input[@placeholder='{0}']/following-sibling::button";
            }
        }

        private string InputFieldXpath
        {
            get
            {
                return "//input[@placeholder='{0}']";
            }
        }

        private string ReadOnlyPartialXpath
        {
            get
            {
                return "//section[{0}]/sympl-dropdown/div";
            }
        }

        private string ToolTipPartialXpath
        {
            get
            {
                return "//div[@class=\"sympl-callout-content\" and text()='{0}']";
            }
        }

        private string GlobalSearchPartialXpath
        {
            get
            {
                return "//div[normalize-space()='{0}']";
            }
        }

        private string SecurityManagerPartialXpath
        {
            get
            {
                return "//*[@id=\"SecurityManager.Select\"]/option[normalize-space()='{0}']";
            }
        }


        private string WebformViewModal
        {
            get
            {
                return "//span[@class='modal-title'][normalize-space()='{0}']";
            }
        }

        private string WebformPdfTitle
        {
            get
            {
                return "//div[contains(@class,'pdfViewer')]//span[normalize-space()='{0}']";
            }
        }

        private string CancelButtonInModal
        {
            get
            {
                return "//div[@class='modal-header draggable']//button[@aria-label='headerButton']";
            }
        }

        private string ImportRuleCheckBoxXpath
        {
            get
            {
                return "//sympl-check-box[@class=\"sympl-label-text hydrated\"]";
            }
        }

        private string RadioButtonStatusXPath
        {
            get
            {
                return "//div[@class='sympl-radio-group radio-inline' and @aria-labelledby='sympl-radio-2-lbl']";
            }
        }

        private string ToggleToolTipTextPartialXPath
        {
            get
            {
                return "//div[text()=\"{0}\"]";
            }
        }

        private string SuccessMessagePopupCloseXPath
        {
            get
            {
                return "//div[@class='sympl-message-bar-icon-close']/button";
            }
        }
        #endregion

        #region Methods

        /// <summary>
        /// Checking the toggle button is displayed or not
        /// </summary>
        /// <param name="expectedStatus"></param>
        /// <returns></returns>
        public bool IsToggleButtonDisplayed(string expectedStatus)
        {
            var element = this.FindElement(this.GetBy(this.ToggleStatusXPath, expectedStatus));
            return element.Displayed;
        }

        /// <summary>
        /// Get the toggle button text
        /// </summary>
        /// <param name="expectedStatus"></param>
        /// <returns></returns>
        public string GetToggleButtonText(string expectedStatus)
        {
            var element = this.FindElement(this.GetBy(this.ToggleStatusXPath, expectedStatus));
            return element.Text;
        }

        /// <summary>
        /// Change the toggle button status
        /// </summary>
        /// <returns></returns>
        public void ChangeToggleStatus(String status)
        {
            this.ClickElement(this.GetBy(ToggleXpath));
        }

        /// <summary>
        /// Checking that the cancel button is enabled
        /// </summary>
        /// <returns></returns>
        public bool IsCancelButtonEnabled(String buttonname)
        {
            var cancelButton = this.FindElement(this.GetBy(this.CancelButtonXPath, buttonname));
            return cancelButton.Enabled;
        }

        /// <summary>
        /// Checking that the save button is enabled
        /// </summary>
        /// <returns></returns>
        public bool IsSaveButtonEnabled(String buttonname)
        {
            this.WaitUntilElementAppears(this.GetBy(this.ButtonPartialXPath, buttonname));
            var saveButton = this.FindElement(this.GetBy(this.ButtonPartialXPath, buttonname));
            return saveButton.Enabled;
        }

        /// <summary>
        /// Checks that all check boxes are disabled
        /// </summary>
        /// <returns></returns>
        public bool VerifyAllCheckboxesDisabled()
        {
            var checkboxes = this.Driver.FindElements(this.GetBy(XpathForAllCheckBoxes));
            return checkboxes.Count == 8 && checkboxes.All(checkbox => checkbox.GetAttribute("disabled") != null);
        }

        /// <summary>
        /// This method will return true if page title is displayed
        /// </summary>
        /// <param name="pageTitle"></param>
        /// <returns>Boolean</returns>
        public bool IsPageDisplayed(string pageTitle)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(PageTitleXPath, pageTitle));

        }

        /// <summary>
        /// Verifies the disabled field using the Getattribute
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public bool VerifyDisabledField(string label)
        {
            this.WaitUntilElementAppears(GetBy(this.PartialFieldNameXPath, label));
            return bool.Parse(this.Driver.WebDriver.FindElement(this.GetBy(this.PartialFieldNameXPath, label)).GetAttribute("disabled"));
        }

        /// <summary>
        /// get elements message 
        /// </summary>
        /// <param name="message">Yes or No</param>
        public string GetSpanContent(string message)
        {
            return this.FindElement(this.GetBy(this.SpanPartialXPath, message)).Text;
        }
        /// <summary>
        /// Click on cancel button
        /// </summary>      
        public void ClickCancelButton()
        {
            this.ClickElement(CancelBtnPopup);
        }

        /// <summary>
        /// Changes the toggle status
        /// </summary>
        /// <param name="status"></param>
        public void ChangeToggleState(string status)
        {
            string currentStatus = GetToggleButtonText();
            if (currentStatus != status)
            {
                this.ClickElement(this.GetBy(ToggleXpath));
            }
        }

        /// <summary>
        /// Returns the Toggle button status text 
        /// </summary>
        /// <returns></returns>
        public string GetToggleButtonText()
        {
            var element = this.FindElement(this.GetBy(this.ToggleStateXpath));
            return element.Text;
        }

        /// <summary>
        /// Verifies the currently selected tab
        /// </summary>
        /// <param name="tabName"></param>
        /// <returns></returns>
        public bool VerifyCurrentlySelectedTab(string tabName)
        {
            return this.FindElement(this.GetBy(this.ButtonPartialXPath, tabName)).GetAttribute("class").Contains("selected");
        }

        /// <summary>
        /// Add attachments one after another and validate
        /// </summary>
        ///  <param name="attachmentNames"></param>
        public bool AddAttachmentsSequentially(IEnumerable<string> attachmentNames)
        {

            string directoryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataFiles");

            foreach (var attachmentName in attachmentNames)
            {
                string filePath = Path.Combine(directoryPath, attachmentName);

                if (File.Exists(filePath))
                {
                    IWebElement elem = this.FindElement(FileUpload);
                    elem.SendKeys(filePath);
                    if (!(attachmentName.Contains("bmp") || attachmentName.Contains("xls") || attachmentName.Contains("mp4")))
                    {
                        this.WaitUntilSpinnerDisappears();
                        this.WaitUntilElementAppears(this.GetBy(SpanPartialXPath, attachmentName));
                        this.ClickElement(this.GetBy(DocumentCloseIcon, attachmentName));
                    }
                    else
                    {
                        this.WaitUntilElementAppears(this.GetBy(SpanPartialXPath, "Invalid document format"));
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Add attachments one after another and validate
        /// </summary>
        ///  <param name="attachmentNames"></param>
        public bool InvalidDocumentUpload(IEnumerable<string> attachmentNames)
        {
            string directoryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataFiles");

            foreach (var attachmentName in attachmentNames)
            {
                string filePath = Path.Combine(directoryPath, attachmentName);

                if (File.Exists(filePath))
                {
                    IWebElement elem = this.FindElement(FileUpload, 15);
                    elem.SendKeys(filePath);
                    this.WaitUntilElementAppears(this.GetBy(SpanPartialXPath, "File size exceeds 4MB"));
                }
            }
            return true;
        }

        /// <summary>
        /// Add New Entity logo button in Logo Master List
        /// </summary>
        public bool IsAddNewEntityButtonDisplayed(String buttonname)
        {
            var EntityButton = this.FindElement(this.GetBy(this.NewLogoConfigurationPartialXPath, buttonname));
            return EntityButton.Displayed;
        }
        /// <summary>
        /// method to check logo alternate text is displayed and has src attribute present
        /// </summary>
        /// <returns></returns>
        public bool IsLogoThumbnailDisplayedAndValid()
        {
            var logoThumbnail = this.FindElement(LogoThumbnailCssSelector);
            return logoThumbnail.Displayed && !string.IsNullOrEmpty(logoThumbnail.GetAttribute("src"));
        }

        /// <summary>
        /// method to construct xpath with column name and today's date and return the date 
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public string GetLogoUploadDate(string columnName)
        {
            string today = DateTime.Now.ToString("MM/dd/yyyy");
            return this.FindElement(this.GetBy(LogoUploadDateXpath, today, columnName)).Text;
        }

        /// <summary>
        /// will return true if table data text is present
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Boolean</returns>
        public bool IsTextDisplayed(string text)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(TableDataTextXpath, text));
        }

        /// <summary>
        /// method to click on a button inside the model
        /// </summary>
        /// <param name="buttonName"></param>
        public void ViewEntityLogoConfig(string buttonName)
        {
            this.ClickElement(this.GetBy(ViewEntityLogoButtonXpath, buttonName));
        }

        /// <summary>
        /// Method to click element based on text
        /// </summary>
        /// <param name="option"></param>
        /// <returns></returns>
        public void ClickTextContentElement(string option)
        {
            this.ClickElement(this.GetBy(this.TextContentPartialXPath, option));
        }

        /// <summary>
        /// verifies that buttonName disabled
        /// </summary>
        /// <param name="buttonName"></param>
        /// <returns></returns>
        public bool VerifiesButtonState(string buttonName)
        {
            return this.FindElement(this.GetBy(this.ButtonPartialXPath, buttonName)).GetAttribute("disabled").Equals("true");
        }

        /// <summary>
        /// Checks if the mentioned field is present
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns></returns>
        public bool IsFieldPresent(string fieldName)
        {
            return this.WaitUntilElementAppears(this.GetBy(this.FieldNamePartialXPath, fieldName));
        }

        /// <summary>
        /// Checking that the button is enabled
        /// <param name="buttonname"></param>
        /// </summary>
        /// <returns></returns>
        public bool IsButtonEnabled(String buttonname)
        {
            if (this.WaitUntilElementAppears(this.GetBy(this.ButtonPartialXPath, buttonname)))
            {
                var button = this.FindElement(this.GetBy(this.ButtonPartialXPath, buttonname));
                return button.Enabled;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// This method will return true if page title is displayed
        /// </summary>
        /// <param name="pageTitle"></param>
        /// <returns>Boolean</returns>
        public bool IsHeadingDisplayed(string pageTitle)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(PageHeadingXPath, pageTitle));
        }

        /// <summary>
        /// This method will return true if page sub title is displayed
        /// </summary>
        /// <param name="pageSubTitle"></param>
        /// <returns>Boolean</returns>
        public bool IsSubHeadingDisplayed(string pageSubTitle)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(PageSubTitleXPath, pageSubTitle));
        }

        /// <summary>
        /// This method will return true if button is displayed
        /// </summary>
        /// <param name="buttonName"></param>
        /// <returns>Boolean</returns>
        public bool IsButtonDisplayed(string buttonName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ButtonPartialXPath, buttonName));
        }

        /// <summary>
        /// This method will return true if table is displayed
        /// </summary>        
        /// <returns>Boolean</returns>
        public bool IsTableDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(TableXpath));
        }

        /// <summary>
        /// Method will return true if scrollWidth is greater than clientWidth
        /// scrollWidth : The total width of the content inside the element, including content that isn't visible due to horizontal scrolling.
        /// clientWidth : The visible width of the element (the portion of the element that is visible without scrolling).
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsHorizontalScrollBarDisplayed()
        {
            bool IsScrollBarPresent = false;
            var element = this.FindElement(this.GetBy(this.ScrollableElementXpath));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)this.Driver.WebDriver;
            long scrollWidth = (long)jse.ExecuteScript("return arguments[0].scrollWidth", element);
            long clientWidth = (long)jse.ExecuteScript("return arguments[0].clientWidth", element);

            IsScrollBarPresent = scrollWidth > clientWidth;
            return IsScrollBarPresent;
        }

        /// <summary>
        /// This method will return true if paginator of table is displayed
        /// </summary>        
        /// <returns>Boolean</returns>
        public bool IsTablePaginationDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(TablePaginatorXpath));
        }

        /// <summary>
        /// This method will return true if logo is displayed
        /// </summary>        
        /// <returns>Boolean</returns>
        public bool IsLogoDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(FooterLogoXpath));
        }

        /// <summary>
        /// This method will return true if text is displayed
        /// </summary>        
        /// <returns>Boolean</returns>
        public bool IsFooterTextDisplayed(string expectedText)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(FooterTextXpath, expectedText));
        }

        /// <summary>
        /// Method will return true if Sorting option is displayed for column
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>Boolean</returns>
        public bool IsSortingOptionDisplayed(string columnName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(SortingOptionXPath, columnName));
        }

        /// <summary>
        /// Method will return true if Filter option is displayed for column
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns>Boolean</returns>
        public bool IsFilterOptionDisplayed(string columnName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(FilterOptionXPath, columnName));
        }

        /// <summary>
        ///  Scroll to bottom of page in the form
        /// </summary>
        public void ScrollToBottomInForm()
        {
            var scrollBarElement = this.FindElement(this.GetBy(this.ScrollBarElement));
            var jse = (IJavaScriptExecutor)this.Driver.WebDriver;
            jse.ExecuteScript("arguments[0].scrollTop = arguments[0].scrollHeight;", scrollBarElement);
        }

        /// <summary>
        /// Checks if the hidden button is present in the DOM and visible in the UI.
        /// </summary>
        /// <param name="button"></param>
        public bool IsHiddenButtonDisplayed(string button)
        {
            var removeButton = this.FindElement(this.GetBy(this.ButtonPartialXPath, button));
            return removeButton.Displayed && removeButton.GetAttribute("hidden") == null;
        }

        /// <summary>
        /// method to check the checkbox
        /// </summary>
        /// <param name="labelText"></param>
        public bool IsCheckBoxChecked(string labelText)
        {
            return this.IsCheckboxChecked(this.FilterCheckboxXpath, labelText);
        }

        /// <summary>
        /// method to check the checkbox
        /// </summary>
        /// <param name="labelText"></param>
        public void ClickCheckBox(string labelText)
        {
            this.ClickElement(this.GetBy(this.LabelPartialXpath, labelText));
        }

        /// <summary>
        /// Verify if checkbox is checked or not
        /// </summary>
        /// <param name="partialXPath"></param>
        /// <param name="elementText"></param>
        /// <returns></returns>
        protected bool IsCheckboxChecked(string partialXPath, params object[] elementText)
        {
            var checkboxXpath = String.Format(partialXPath, elementText);
            string script = $@"
        var xpathExpression = ""{checkboxXpath}"";
        var checkbox = document.evaluate(xpathExpression, document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue;
            if (checkbox) {{
                    return checkbox.checked;
            }} else {{
                    return false;
            }}
            ";

            var isChecked = (bool)((IJavaScriptExecutor)this.Driver.WebDriver).ExecuteScript(script);
            return isChecked;
        }

        /// <summary>
        /// Verifies edit comment model is displayed on clicking edit
        /// </summary>
        /// <returns></returns>
        public bool IsEditCommentModalDisplayed(string modalTittle)
        {
            return this.WaitUntilElementAppears(this.GetBy(this.SpanPartialXPath, modalTittle));
        }

        /// <summary>
        /// verifies if save button is disabled
        /// </summary>
        /// <returns></returns>
        public bool IsSaveButtonDisabled()
        {
            return this.FindElement(this.GetBy(this.SaveButtonXPath)).GetAttribute("disabled") != null;
        }

        /// <summary>
        /// method to click on the next button in the pagination
        /// </summary>
        /// <returns></returns>
        public IWebElement IsNextButtonEnabled()
        {
            var nextPageButtonLocator = this.FindElement(this.GetBy(PaginationNextButtonXpath));
            this.Driver.Actions.MoveTo(this.GetBy(PaginationNextButtonXpath));
            return nextPageButtonLocator;
        }

        /// <summary>
        /// method to the collection of all the entities present in the table
        /// </summary>
        /// <returns></returns>
        public ICollection<IWebElement> GetEntitiesPresentInCurrentPageInTable()
        {
            return this.Driver.FindElements(this.GetBy(EntitiesTableXpath));
        }

        /// <summary>
        ///  method to click on popup button
        /// </summary>
        /// <param name="buttonName"></param>
        public void ClickOnPopUpButton(string buttonName)
        {
            this.ClickElement(this.GetBy(PopUpCloseButtonXpath, buttonName));
        }

        /// <summary>
        /// method to check if the Document section is displayed or not inside Process instance Card       
        /// </summary>
        /// <returns></returns>
        public bool IsDocumentsSectionDisplayed()
        {
            return this.FindElement(this.GetBy(this.ScrollableDocumentSectionXpath)).Displayed;
        }

        /// <summary>
        /// Method will return true if scrollHeight is greater than clientHeight
        /// scrollHeight : The total Height of the content inside the element, including content that isn't visible due to Vertical scrolling.
        /// clientHeight : The visible Height of the element (the portion of the element that is visible without scrolling).
        /// </summary>
        /// <returns></returns>
        public bool IsVerticalScrollBarDisplayed()
        {
            bool IsScrollBarPresent = false;
            var element = this.FindElement(this.GetBy(this.ScrollableDocumentSectionXpath));
            IJavaScriptExecutor jse = (IJavaScriptExecutor)this.Driver.WebDriver;

            long scrollHeight = (long)jse.ExecuteScript("return arguments[0].scrollHeight", element);
            long clientHeight = (long)jse.ExecuteScript("return arguments[0].clientHeight", element);
            IsScrollBarPresent = scrollHeight > clientHeight;
            return IsScrollBarPresent;
        }

        /// <summary>
        /// method to if all the documents are present in the document section of the process instance
        /// </summary>
        /// <param name="documentName"></param>
        /// <returns></returns>
        public bool IsDocumentAvailableInSection(string documentName)
        {
            try
            {
                var element = this.FindElement(this.GetBy(DocumentsNameXpath, documentName));
                return element.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if the mentioned field is present
        /// </summary>
        /// <param name="fieldName">Field name</param>
        /// <returns></returns>
        public bool IsFieldsStatusPresent(string fieldName)
        {
            this.WaitUntilSpinnerDisappears();
            return this.Driver.Actions.IsPresent(this.GetBy(FieldNamePartialXPath, fieldName));
        }

        /// <summary>
        /// Checks if the icon is present
        /// </summary>
        /// <returns></returns>
        public bool IsEyeIconIsPresent()
        {
            return this.Driver.Actions.IsVisible(this.GetBy(EyeIconDisplayedXPath));
        }

        /// <summary>
        /// Select The Record From Grid
        /// </summary>
        public void SelectRecordsFromGrid()
        {
            this.ClickElement(this.GetBy(this.SelectRecordPartialXpath, "1"));
        }

        /// <summary>
        /// Clicks on the hyperlink text
        /// </summary>
        /// <param name="linkText"></param>
        public void clickHyperLinkByText(String linkText)
        {
            this.ClickElement(this.GetBy(this.HyperLinkPartialXPath, linkText));
        }

        /// <summary>
        /// Checks if the cross mark is present
        /// </summary>
        public bool IsCrossmarkIsPresent()
        {
            return this.Driver.Actions.IsVisible(this.GetBy(CrossMarkXPath));
        }

        /// <summary>
        /// Verifies the readonly field using the Getattribute
        /// </summary>
        public bool VerifyReadonlyField()
        {
            return bool.Parse(this.Driver.WebDriver.FindElement(this.GetBy(this.ReadOnlyXPath)).GetAttribute("readonly"));
        }

        /// <summary>
        ///Back to Dashboard
        /// </summary>
        public void ReturnToDashBoard()
        {
            this.WaitUntilSpinnerDisappears();
            this.ClickElement(this.ReturnToDashBoardXPath);
            this.WaitUntilSpinnerDisappears();
        }

        /// <summary>
        /// Method will return text of the Webform Display Name
        /// </summary>
        /// <returns>String</returns>
        public string GetWebformDisplayNamme()
        {
            return this.GetElementText(WebformDisplayNameXpath);
        }

        /// <summary>
        /// method to check download a copy link is avialable in the after opening notification
        /// </summary>
        /// <param name="webform"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool CheckDownloadACopyOption(string webform, string key, string value)
        {
            string formattedValue = FormatValue(value);
            string expectedMessage = $" {webform} in {key} for {formattedValue}                     was Completed. ";
            return this.Driver.Actions.IsPresent(this.GetBy(DownloadACopyXpath, expectedMessage));
        }

        /// <summary>
        /// Helper method to transform a value string from an unsplit format (e.g.
        /// "sPortalAutomationEntity[DoNotAlter]") into a formatted version (e.g.
        /// "sPortal Automation Entity [Do Not Alter]") that matches the application's text.
        /// </summary>
        /// <param name="value">The input value to format.</param>
        /// <returns>The formatted value with inserted spaces.</returns>
        private string FormatValue(string value)
        {
            if (value.Contains("["))
            {
                int index = value.IndexOf("[");
                string part1 = value.Substring(0, index); // e.g. "sPortalAutomationEntity"
                string part2 = value.Substring(index);      // e.g. "[DoNotAlter]"

                if (part1.StartsWith("sPortal"))
                {
                    string prefix = "sPortal";
                    string rest = part1.Substring(prefix.Length); // e.g. "AutomationEntity"                    
                    string formattedRest = Regex.Replace(rest, "([A-Z])", " $1").Trim();
                    part1 = prefix + " " + formattedRest;
                }
                else
                {
                    part1 = Regex.Replace(part1, "(?<=[a-z])(?=[A-Z])", " ");
                }
                string inner = part2.Trim('[', ']');
                string formattedInner = Regex.Replace(inner, "(?<=[a-z])(?=[A-Z])", " ");
                part2 = "[" + formattedInner + "]";

                return part1 + " " + part2;
            }
            else
            {
                return Regex.Replace(value, "(?<=[a-z])(?=[A-Z])", " ");
            }
        }

        /// <summary>
        /// method to enter text in input field box
        /// </summary>
        /// <param name="userText"></param>
        public void EnterTextInNameFieldBox(string userText)
        {
            this.SendKeys(this.GetBy(this.TextInputFieldPartialXPath, "Search"), (userText + Keys.Enter));
        }

        /// <summary>
        /// method to enter text in input field box
        /// </summary>
        /// <param name="name"></param>
        /// <param name="userText"></param>
        public void EnterTextInNameFieldBox(string name, string userText)
        {
            this.SendKeys(this.GetBy(this.TextInputFieldPartialXPath, name), userText);
        }

        /// <summary>
        /// method to select the dropdown
        /// </summary>
        public void ClickDropdown()
        {
            this.ClickElement(this.GetBy(DropdownXpath));
        }

        /// <summary>
        /// to select the from option from the dropdown
        /// </summary>
        /// <param name="optionName"></param>
        public void SelectFromMyDocumentLibrary(string optionName)
        {
            this.ClickElement(this.GetBy(FromMyDocumentLibrarXpath, optionName));
        }

        /// <summary>
        /// to get the list of the all the documents from document library and seleect the first one
        /// </summary>
        public void ClickFirstDocument()
        {
            this.WaitUntilSpinnerDisappears();
            this.WaitUntilElementAppears(SelectFirstDocumentXpath);
            ICollection<IWebElement> documents = this.Driver.FindElements(SelectFirstDocumentXpath);
            if (documents.Count > 0)
            {
                IWebElement firstDocument = documents.First();
                firstDocument.Click();
            }
        }

        /// <summary>
        /// method to the attach the file
        /// </summary>
        /// <param name="buttonName"></param>
        public void ClickAttachButton(string buttonName)
        {
            this.ClickElement(this.GetBy(AttachButtonXpath, buttonName));
        }

        /// <summary>
        /// method to click on Delete icon
        /// </summary>
        /// <param name="documentName"></param>
        public void ClickDeleteIcon(string documentName)
        {
            this.ClickElement(this.GetBy(DeleteIconXpath, documentName));
        }

        /// <summary>
        /// verify if OK button is disabled
        /// </summary>
        /// <param name="buttonName"></param>
        /// <returns></returns>
        public bool VerifyOkButtonState(string buttonName)
        {
            return this.FindElement(this.GetBy(FormOkButton, buttonName)).GetAttribute("disabled") == "true";
        }

        /// <summary>
        /// method to check if the file exeeds warning is coming or not
        /// </summary>
        /// <returns></returns>
        public bool IsFileExceedsWarningExist()
        {
            return this.WaitUntilElementAppears(this.GetBy(FileExceedsLimitXPath));
        }

        /// <summary>
        /// method to verify if the webform tabs are present
        /// </summary>
        /// <param name="tabs"></param>
        /// <returns></returns>
        public bool VerifyWebformTabs(string tabs)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ButtonPartialXPath, tabs));
        }

        /// <summary>
        /// method to get all the entities present in the entity switcher
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllListedEntities()
        {
            ICollection<IWebElement> entitiesFromSwitcher = this.Driver.FindElements(this.GetBy(EntitiesListedInEntitySwitcherXpath));
            List<string> entityTexts = new List<string>();

            foreach (IWebElement entity in entitiesFromSwitcher)
            {
                entityTexts.Add(entity.Text);
            }
            return entityTexts;
        }


        /// <summary>
        /// method to get all the entities present in the entity dropdown
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllListedEntitiesInDropdown()
        {
            this.ClickElement(this.GetBy(EntityDropdownXpath));
            ICollection<IWebElement> entitiesFromSwitcher = this.Driver.FindElements(this.GetBy(EntitiesListedInEntityDropdownXpath));
            List<string> entityTexts = new List<string>();

            foreach (IWebElement entity in entitiesFromSwitcher)
            {
                entityTexts.Add(entity.Text);
            }
            return entityTexts;
        }

        /// <summary>
        /// will return true if text is present
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Boolean</returns>
        public bool IsTextPresent(string text)
        {
            try
            {
                this.WaitUntilElementAppears(this.GetBy(TextContentPartialXPath, text), 5);
                return this.Driver.Actions.IsPresent(this.GetBy(TextContentPartialXPath, text));
            }
            catch (Exception)
            {
                return false;
            }
        }


        /// <summary>
        /// Verifies Signature pad is displayed in priviledge form
        /// </summary>
        public bool IsSignaturePadDisplayed()
        {
            return this.WaitUntilElementAppears(this.GetBy(SignaturePadXpath));
        }

        /// <summary>
        /// Click on Signature pad in priviledge form
        /// </summary>
        public void ClickSignaturePad()
        {
            //this.Driver.Actions.MoveTo(this.GetBy(SignaturePadXpath));
            this.ClickElement(this.GetBy(SignaturePadXpath));
        }


        /// <summary>
        /// Select first page to show all entities
        /// </summary>
        /// <returns></returns>
        public void SelectFirstPage()
        {
            if (this.FindElement(this.GetBy(SelectPagePartialXpath, "first")).Enabled)
            {
                this.ClickElement(this.GetBy(SelectPagePartialXpath, "first"));
            }
        }

        /// <summary>
        /// will return true if table data text is present
        /// </summary>
        /// <param name="text"></param>
        /// <returns>Boolean</returns>
        public bool IsEntityDisplayed(string text)
        {
            if (this.Driver.Actions.IsPresent(this.GetBy(TableDataTextXpath, text)))
            {
                return true;
            }

            for (int i = 1; i < this.Driver.FindElements(this.GetBy(TotalPagesXpath)).Count; i++)
            {
                this.ClickElement(this.GetBy(SelectPagePartialXpath, "next"));


                if (this.Driver.Actions.IsPresent(this.GetBy(TableDataTextXpath, text)))
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Enter more/less 200 characters at add comment in priviledge form
        /// </summary>
        public void EnterTextIntoCommentBox(string text)
        {
            this.Driver.Actions.SendKeys(this.GetBy(TextareaXpath), Keys.Control + "A" + Keys.Delete + "  ");
            this.Driver.Actions.SendKeys(this.GetBy(TextareaXpath), DataManager.Utils.StringExtension.GenrateRandomString(Convert.ToInt32(text)));
        }

        /// <summary>
        /// Method to get all checkboxes and uncheck the number(s) provided checkbox
        /// </summary>
        /// <param name="numberOfCheckboxToBeChecked"></param>
        public void CheckboxToSelect(int numberOfCheckboxToBeChecked)
        {
            var checkboxes = this.Driver.FindElements(AllCheckboxesXpath).ToList();

            for (int i = 0; i < checkboxes.Count; i++)
            {
                IWebElement checkboxElement = checkboxes[i];
                bool isChecked = IsCheckboxChecked(checkboxElement);

                if (i < numberOfCheckboxToBeChecked)
                {
                    if (!isChecked)
                    {
                        checkboxElement.Click();
                    }
                }
                else
                {
                    if (isChecked)
                    {
                        checkboxElement.Click();
                    }
                }
            }
        }

        /// <summary>
        ///  method to check if the checkbox is already checked
        /// </summary>
        /// <param name="checkbox"></param>
        /// <returns></returns>
        private bool IsCheckboxChecked(IWebElement checkbox)
        {
            try
            {
                IWebElement input = checkbox.FindElement(SingleCheckboxXpath);
                return input.Selected;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        ///  method to verify sorting on the grid and check whether hyperlink is enabled or not
        /// </summary>
        /// <param name="selectedCount"></param>
        /// <exception cref="Exception"></exception>
        public void VerifyPrivilegesSorting(int selectedCount)
        {
            var rows = this.Driver.FindElements(StandarPrivilegeTableXpath);
            List<string> statuses = new List<string>();

            foreach (var row in rows)
            {
                string status = row.FindElement(TableStatusXpath).Text.Trim();
                statuses.Add(status);
                bool isHyperlinkDisplayed = row.FindElement(TableViewMoreLinkXpath).Displayed;
                if (!isHyperlinkDisplayed)
                {
                    throw new Exception("Hyperlink is not displayed for a row.");
                }
            }
            bool isSortedCorrectly = statuses.Take(selectedCount).All(s => s == "Requested") &&
                                     statuses.Skip(selectedCount).All(s => s == "Not Requested");

            if (!isSortedCorrectly)
            {
                throw new Exception("Privileges are not sorted correctly based on selection.");
            }
        }

        /// <summary>
        /// Click on link text
        /// </summary>
        /// <param name="linkText"></param>
        public void ClickOnLinkText(string linkText)
        {
            this.WaitUntilElementAppears(this.GetBy(this.LinkTextPartialXpath, linkText));
            this.ScrollToElement(this.GetBy(this.LinkTextPartialXpath, linkText));
            this.ClickElement(this.GetBy(this.LinkTextPartialXpath, linkText));
        }

        /// <summary>
        /// method to click on the button in the Changes not saved popup
        /// </summary>
        /// <param name="option"></param>
        public void ClickButtonInAcceptSubmitDocPopUp(string option)
        {
            this.FindElement(this.GetBy(ButtonPartialXPath, option)).Click();
        }

        /// <summary>
        /// Select specific priviledge form for review request
        /// /// <param name="form"></param>
        /// /// <param name="action"></param>
        /// </summary>
        public void SelectPriviledgeForm(string form, string action)
        {
            bool isSelected = this.FindElement(this.GetBy(SelectPriviledgeFormPartialXpath, form)).Displayed;

            if (action == "Uncheck" && isSelected)
            {
                this.ClickElement(this.GetBy(SelectPriviledgeFormPartialXpath, form));
            }
            else if (action == "Check" && !isSelected)
            {
                this.ClickElement(this.GetBy(SelectPriviledgeFormPartialXpath, form));
            }
        }

        /// <summary>
        /// Method to get all the requested/not requested privilege forms
        /// /// /// <param name="privilegeName"></param>
        /// /// <param name="status1"></param>
        /// /// /// <param name="status2"></param>
        /// </summary>
        public Dictionary<string, string> GetActualPrivilegeValues(string privilegeName, string status1, string status2)
        {
            var privilegeFormValues = this.Driver.FindElements(this.GetBy(PriviledgeFormValuesXpath));
            var actualPrivilegeFormValues = new Dictionary<string, string>();

            string currentText = null;
            string currentStatus = null;

            foreach (var privilege in privilegeFormValues)
            {
                string trimmedText = privilege.Text.Trim();

                if (trimmedText.Contains(privilegeName))
                {
                    currentText = trimmedText;
                }
                else if (trimmedText.Contains(status1) || trimmedText.Contains(status2))
                {
                    if (trimmedText.Equals("Requested\r\nRequested"))
                    {
                        currentStatus = status1;
                    }
                    else
                    {
                        currentStatus = trimmedText;
                    }
                }
                if (currentText != null && currentStatus != null)
                {
                    actualPrivilegeFormValues[currentText] = currentStatus;
                    currentText = null;
                    currentStatus = null;
                }
            }
            return actualPrivilegeFormValues;
        }

        /// <summary>
        /// Will return true if Alert message displayed to Archive/Edit/Active the process template
        /// </summary>
        /// <param name="alert"></param>
        /// <returns>Boolean</returns>
        public bool IsAlertMessageDisplayed(string alert)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(DivPartialXPath, alert));
        }

        /// <summary>
        /// Method will scroll to end of the document.
        /// </summary>
        public void ScrollForm()
        {
            this.ScrollToBottomOfElement(this.RequestFormPageXpath);
        }

        /// <summary>
        /// Method to click on the canvas
        /// </summary>        
        public void ClickOnTheCanvas()
        {
            this.ClickElement(this.GetBy(this.CanvasXpath));
        }

        /// <summary>
        /// Select first page to show all entities
        /// </summary>
        /// <param name="tabName"></param>
        /// <returns>Boolean</returns>
        public bool IsTabDisplayed(string tabName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(this.TableNameXpath, tabName));
        }

        /// <summary>
        /// This method will return true if Radio Button is displayed
        /// </summary>
        /// <param name="radioButtonName"></param>
        /// <returns>Boolean</returns>
        public bool IsRadioButtonTextDisplayed(string radioButtonName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(this.SpanPartialXPath, radioButtonName));
        }

        /// <summary>
        /// method to click on the button by text
        /// </summary>
        /// <param name="buttonName"></param>
        public void ClickOnPopupButton(string buttonName)
        {
            this.ClickElement(this.GetBy(PopupButtonPartialXpath, buttonName));
        }

        /// <summary>
        /// method to scroll the button by text
        /// </summary>
        /// <param name="buttonName"></param>
        public void ScrollToButtonByText(string buttonName)
        {
            this.WaitUntilElementAppears(this.GetBy(ButtonPartialXPath, buttonName));
            this.ScrollToElement(this.GetBy(ButtonPartialXPath, buttonName));
        }

        /// <summary>
        /// Verify notification icon is present
        /// </summary>
        /// <returns></returns>
        public bool IsNotificationIconDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(NotificationIconXPath));
        }

        /// <summary>
        /// verify online help is displayed
        /// </summary>
        /// <returns></returns>
        public bool IsOnlineHelpDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(OnlinebuttonXPath));
        }

        /// <summary>
        /// verify profile is displayed
        /// </summary>
        /// <returns></returns>
        public bool IsProfileDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ProfileXPath));
        }

        /// <summary>
        /// verify footer is displayed
        /// </summary>
        /// <returns></returns>
        public bool IsFooterReservedDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ProfileXPath));
        }

        /// <summary>
        /// verify button status
        /// </summary>
        /// <param name="buttonName"></param>
        /// <returns></returns>
        public bool VerifyButtonStatus(string buttonName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ButtonPartialXPath, buttonName));
        }

        /// <summary>
        /// select the record in the grid
        /// </summary>
        public void ClickOnRecord()
        {
            this.ClickElement(this.GetBy(this.SelectRecordXpath));
        }

        /// <summary>
        /// verify record is highlighted
        /// </summary>
        /// <returns>Boolean</returns>
        public bool VerifyRecordHidglighted()
        {
            return this.Driver.Actions.IsVisible(this.GetBy(SelectRecordXpath));
        }

        /// <summary>
        /// Method to click Edit on fortis/apollo entity
        /// </summary>
        /// <param name="entity"></param>
        public void ClickEditOnAdminEntity(string entity)
        {
            this.ClickElement(this.GetBy(this.EditAdminEntityPartialXpath, entity));
        }

        /// <summary>
        /// Method to enable/disable the DocuSign
        /// </summary>
        /// <param name="status"></param>
        public void EnableDisableDosuSign(string status)
        {
            string targetStatus = status == "Enable" ? "Disable" : "Enable";

            if (this.Driver.Actions.IsPresent(this.GetBy(ToggleStatusXPath, targetStatus)))
            {
                this.ClickElement(this.GetBy(this.DocuSignStatusXpath));
            }
        }

        /// <summary>
        /// Method to click pagination(items per page) dropdown
        /// </summary>
        public void ClickOnPaginationDropdown()
        {
            this.ClickElement(this.GetBy(PaginationDropdownXpath));
        }

        /// <summary>
        /// Get all values in pagination(items per page) dropdown
        /// </summary>
        /// <returns>List<string></returns>
        public List<string> GetAllPaginationDropdownValues()
        {
            this.WaitUntilElementAppears(this.GetBy(PaginationDropdownValuesXpath));
            var dropdownElements = this.Driver.FindElements(GetBy(PaginationDropdownValuesXpath));
            var dropdownValues = new List<string>();

            foreach (var dropdownElement in dropdownElements)
            {
                dropdownValues.Add(dropdownElement.Text.Trim());
            }
            return dropdownValues;
        }

        /// <summary>
        /// Return true if default pagination (items per page) value displayed
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns>Boolean</returns>
        public bool IsDefaultPaginationDropdownValueDisplayed(string defaultValue)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(PaginationDropdownDefaultValueXpath, defaultValue));
        }

        /// <summary>
        /// Return true if all pages in pagination displayed
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsPaginationAllPagesDisplayed()
        {
            for (int i = 1; i <= this.Driver.FindElements(this.GetBy(TotalPagesXpath)).Count; i++)
            {
                if (!this.Driver.Actions.IsPresent(this.GetBy(PaginationPagesPartialXpath, i)))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Return true if specific(passed) page opened
        /// </summary>
        /// <param name="page"></param>
        /// <returns>Boolean</returns>
        public bool IsSpecificPageOpened(string page)
        {
            this.ClickElement(this.GetBy(PaginationPagesPartialXpath, page));
            return this.Driver.Actions.IsPresent(this.GetBy(CurrentPagePartialXpath, page));
        }

        /// <summary>
        /// Method to click pages using left/right arrows
        /// </summary>
        /// <param name="arrow"></param>
        /// <returns></returns>
        public void NavigateToPage(string arrow)
        {
            if (this.FindElement(this.GetBy(SelectPagePartialXpath, arrow)).Enabled)
            {
                this.ClickElement(this.GetBy(SelectPagePartialXpath, arrow));
            }
        }

        /// <summary>
        /// Return true if corresponding page opened by left/right arrow click
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public bool IsPageOpenByArrow(string page)
        {
            if (page == "last")
            {
                var elements = this.Driver.FindElements(this.GetBy(TotalPagesXpath));
                string lastElement = elements.Last().Text.Trim();
                return this.Driver.Actions.IsPresent(this.GetBy(CurrentPagePartialXpath, lastElement));
            }
            else
            {
                return this.Driver.Actions.IsPresent(this.GetBy(CurrentPagePartialXpath, page));
            }
        }

        /// <summary>
        /// Method will scroll to end of the document.
        /// </summary>
        public void ScrollToPagination()
        {
            this.ScrollToBottomOfElement(this.TablePaginatorXpath);
        }

        /// <summary>
        /// Method to select the specific entity from Associated Entity dropdown
        /// </summary>  
        /// <param name="dropdown"></param>
        /// <param name="entity"></param>
        public void SelectAssociatedEntityDropDown(string dropdown, string entity)
        {
            this.ClickElement(this.GetBy(this.DropDownsPartialXPath, dropdown));
            this.Driver.Actions.WaitUntil(a => a.IsVisible(this.GetBy(this.checkboxsXpath, entity)));
            this.ActionClickOnElement(this.GetBy(this.checkboxsXpath, entity));
            this.WaitUntilSpinnerDisappears();
        }

        /// <summary>
        /// Verifies the value
        /// </summary>
        public bool VerifyValue()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ReadValueXpath));
        }

        /// <summary>
        /// to verify Icon displayed at perticular step
        /// </summary>
        /// <param name="stepName"></param>
        /// <param name="iconName"></param>
        public bool IsStepWithIconDisplayed(string stepName, string iconName)
        {
            return this.WaitUntilElementAppears(this.GetBy(this.IconWithStepNumberXpath, stepName, iconName), 1);
        }

        /// <summary>
        /// Verify presence of Sign this form button.
        /// </summary>
        public bool IsButtonPresent(string buttonName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ButtonXpath, buttonName));
        }

        /// <summary>
        /// Method to select logo in settings page
        /// </summary>        
        /// <param name="logoname"></param>
        public void SelectLogo(string logoname)
        {
            this.ClickElement(this.GetBy(this.LogoPartialXpath, logoname));
        }

        /// <summary>
        /// Method will return true if actual and expected field values are same.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="expectedValue"></param>
        /// <returns>Boolean</returns>
        public bool VerifyFieldValue(string field, string expectedValue)
        {
            var actualValue = this.GetElementText(this.GetBy(this.FieldValuePartialXpath, field));
            return actualValue.Contains(expectedValue);
        }

        /// <summary>
        /// Method will return true if actual and expected JSON File names are same.
        /// </summary>        
        /// <param name="expectedValue"></param>
        /// <returns>Boolean</returns>
        public bool VerifyJsonFileFieldValue(string expectedValue)
        {
            var actualValue = this.GetElementText(this.GetBy(this.JsonFileNameXpath));
            return actualValue.Contains(expectedValue);
        }

        /// <summary>
        /// Method will click on X button of uploaded json file
        /// </summary>
        public void RemoveJsonFile()
        {
            this.ClickElement(this.GetBy(this.JsonFileRemoveButtonXpath));
        }

        /// <summary>
        /// Method will click on X button of eedit popup
        /// </summary>
        public void CloseEditPopUp()
        {
            this.ClickElement(this.GetBy(this.EditPopupCloseButtonXpath));
        }

        /// <summary>
        /// Scroll to the bottom of popup
        /// </summary>
        public void ScrollPopUp()
        {
            this.ScrollToBottomOfElement(this.ScrollablePopupXpath);
        }

        /// <summary>
        /// Verifies that only the expected number of rows is present in the grid.
        /// </summary>
        /// <param name="expectedRowCount"></param>
        /// <returns></returns>
        public bool VerifyRowCount(int expectedRowCount)
        {
            var rows = this.Driver.FindElements(this.GetBy(this.TableRowXpath));
            return rows.Count == expectedRowCount;
        }

        /// <summary>
        /// Method to click remove link for file
        /// </summary>
        public void RemoveFileLink()
        {
            this.ClickElement(this.GetBy(this.FileRemoveLinkXpath));
            this.WaitUntilSpinnerDisappears();
        }

        /// <summary>
        /// Method to click filename to download
        /// </summary>
        public void ClickFilenameToDownload()
        {
            this.ClickElement(this.GetBy(this.DownloadFilenameXpath));
        }

        /// <summary>
        /// Return true if file is displayed to download
        /// </summary>
        /// <returns>bool</returns>
        public bool IsJsonFileDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(DownloadFilenameXpath));
        }

        /// <summary>
        /// Return true if radiobutton is selected
        /// </summary>
        /// <param name="value"></param>
        /// <returns>Boolean</returns>
        public bool IsRadioButtonChecked(string value)
        {
            return this.FindElement(this.GetBy(RadioButtonPartialXpath, value)).Selected;
        }

        /// <summary>
        /// Method to enter values in the text box
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="value"></param>
        public void EnterValuesinTextbox(string placeholder, string value)
        {
            this.FindElement(this.GetBy(this.PlaceholderPartialXpath, placeholder)).SendKeys(value);
        }

        /// <summary>
        /// Method to click expand all link
        /// </summary>
        /// <returns></returns>
        public void ClickExpandAllLink(string linkName)
        {
            this.ClickElement(this.GetBy(this.ExpandAllLink, linkName));
        }

        /// <summary>
        /// Verify presence of radio button 
        /// </summary>
        public bool IsRadioButtonPresent(string buttonName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(this.SpanPartialXPath, buttonName));
        }

        /// <summary>
        /// Checks if fields are mandatory
        /// </summary>
        /// <returns></returns>
        public bool IsFieldsMandatory(string fieldName)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(MandatoryFieldsXPath, fieldName));
        }

        /// <summary>
        /// Method will select value for the specific field from the dropdown
        /// </summary>
        /// <param name="field"></param>
        /// <param name="value"></param>
        public void FillDetails(string field, string value)
        {
            this.ClickElement(this.GetBy(SelectDropDownButtonPartialXPath, field));
            this.WaitUntilElementAppears(this.GetBy(this.SpanPartialXPath, value));
            this.ClickElement(this.GetBy(this.SpanPartialXPath, value));
        }

        /// <summary>
        /// Method will enter text for the specific text field
        /// </summary>
        /// <param name="field"></param>
        /// <param name="text"></param>
        public void EnterText(string field, string text)
        {
            this.EnterTextInTextBox(this.GetBy(this.InputFieldXpath, field), text);
        }

        /// <summary>
        /// Method will return true if tool tip text of toogle is displayed.
        /// </summary>
        /// <param name="expectedText"></param>
        /// <returns>Boolean</returns>
        public bool VerifyToggleToolTipText(string expectedText)
        {
            this.Driver.Actions.MoveTo(this.GetBy(this.ToggleXpath));
            this.WaitUntilElementAppears(this.GetBy(this.ToggleToolTipTextPartialXPath, expectedText));
            return this.VerifyElementIsDisplayed(this.GetBy(this.ToggleToolTipTextPartialXPath, expectedText));
        }

        /// <summary>
        ///Clicking On Sign This Form
        /// </summary>
        public void ClickSignThisFormCommonButton()
        {
            this.WaitUntilSpinnerDisappears();
            this.ClickElement(this.SignThisFormCommonXPath);
        }

        /// <summary>
        /// Return true if archive icon is displayed
        /// </summary>
        /// <returns></returns>
        public bool IsArchiveIconDisplayed()
        {
            return this.Driver.Actions.IsPresent(this.GetBy(ArchiveIconXpath));
        }

        /// <summary>
        /// Method to click out side popup of the page to close the filter popup
        /// <param name="clickoutsidepopup"></param>
        /// </summary>
        public void ClickOutsidePopUp(string pageTitle)
        {
            this.ClickElement(this.GetBy(PageHeadingXPath, pageTitle));
        }

        /// <summary>
        /// Scroll to the bottom of popup and click on X button of uploaded json file
        /// </summary>
        public void ScrollPopUpAndRemoveJsonFile()
        {
            this.ScrollToBottomOfElement(this.ScrollablePopupXpath);
            this.WaitUntilElementAppears(this.GetBy(this.JsonFileRemoveButtonXpath));
            this.ClickElement(this.GetBy(this.JsonFileRemoveButtonXpath));
        }

        /// <summary>
        /// Add attachments one after another and validate
        /// </summary>
        ///  <param name="attachmentNames"></param>
        public bool AddInvalidAttachmentsSequentially(IEnumerable<string> attachmentNames)
        {
            var directoryPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "DataFiles");
            foreach (var attachmentName in attachmentNames)
            {
                var filePath = Path.Combine(directoryPath, attachmentName);
                if (File.Exists(filePath))
                {
                    IWebElement elem = this.FindElement(FileUpload);
                    elem.SendKeys(filePath);
                    this.WaitUntilElementAppears(this.GetBy(SpanPartialXPath, "Invalid document format"));
                }
            }
            return true;
        }

        /// <summary>
        /// Method to verify alert pop up
        /// </summary>
        /// <returns></returns>
        public bool VerifyAlertPopUP()
        {
            return this.VerifyElementIsDisplayed(this.GetBy(this.SpanPartialXPath, "Alert"));
        }


        /// <summary>
        /// Verifies the readonly field using the Getattribute
        /// </summary>
        public bool VerifyReadonlyFieldPartialXPath(string field)
        {
            switch (field)
            {
                case "Subscription ID/Name":
                    return this.Driver.WebDriver.FindElement(this.GetBy(this.ReadOnlyPartialXpath, 2)).GetAttribute("class").Contains("disabled");
                case "Entity":
                    return this.Driver.WebDriver.FindElement(this.GetBy(this.ReadOnlyPartialXpath, 4)).GetAttribute("class").Contains("disabled");
                case "Process Type":
                    return this.Driver.WebDriver.FindElement(this.GetBy(this.ReadOnlyPartialXpath, 6)).GetAttribute("class").Contains("disabled");
                case "Privileging Mode":
                    return bool.Parse(this.Driver.WebDriver.FindElement(this.GetBy(this.ReadOnlyXPath)).GetAttribute("readonly"));
                default:
                    throw new ArgumentException("Invalid field type specified.");
            }
        }

        /// <summary>
        /// Verify Tooltip text.
        /// </summary>
        public Boolean CheckToolTipText(string elementValue)
        {
            this.Driver.Actions.MoveTo(GetBy(this.ToggleXpath));
            return this.Driver.WaitUntil(a => a.FindElement(GetBy(this.ToolTipPartialXpath, elementValue)).Displayed);
        }

        /// <summary>
        /// Return true if the fields are visible
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns>Boolean</returns>
        public bool IsSearchFieldDisplayed(string defaultValue)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(this.GlobalSearchPartialXpath, defaultValue));
        }

        /// <summary>
        /// Return true if the fields are visible
        /// </summary>
        /// <param name="defaultValue"></param>
        /// <returns>Boolean</returns>
        public bool IsSecurityManagerFieldDisplayed(string defaultValue)
        {
            return this.Driver.Actions.IsPresent(this.GetBy(this.SecurityManagerPartialXpath, defaultValue));
        }

        /// <summary>
        /// User click on tab 
        /// <param name="tabName"></param>
        /// </summary> 
        public void ClickTab(string tabName)
        {
            this.ClickElement(this.GetBy(this.ButtonPartialXPath, tabName));
        }


        /// <summary>
        /// Method to verify doc library view webform modal window 
        /// </summary>
        /// <param name="webformName"></param>
        /// <returns></returns>
        public bool IsWebformModalDisplayed(string webformName)
        {
            return this.WaitUntilElementAppears(this.GetBy(WebformViewModal, webformName));
        }

        /// <summary>
        /// Method to verify Webform pdf in doc library view webform modal window
        /// </summary>
        /// <param name="webformName"></param>
        /// <returns></returns>
        public bool IsWebformPdfDisplayedInModal(string webformName)
        {
            return this.WaitUntilElementAppears(this.GetBy(WebformPdfTitle, webformName));
        }

        /// <summary>
        /// Clicks on X button in modal
        /// </summary>
        public void ClickCancelButtonInModal()
        {
            this.ClickElement(this.GetBy(CancelButtonInModal));
        }

        /// <summary>
        /// verifies import rule is grayed out
        /// </summary>
        /// <param name="acceptanceMethod"></param>
        public bool IsImportRuleGrayedOut()
        {
            return this.FindElement(this.GetBy(this.ImportRuleCheckBoxXpath)).GetAttribute("disabled") == "true";
        }


        /// <summary>
        /// Checking that the button is enabled 
        /// </summary>
        /// <returns></returns>
        public bool IsRadioButtonEnabled()
        {
            this.ScrollToElement(this.GetBy(RadioButtonStatusXPath));
            var button = this.FindElement(this.GetBy(this.RadioButtonStatusXPath));
            return button.Enabled;
        }

        /// <summary>
        /// Method to enter values in the text box
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="value"></param>
        public void EnterValuesTextbox(string placeholder, string value)
        {
            this.FindElement(this.GetBy(this.InputFieldXpath, placeholder)).Clear();
            this.FindElement(this.GetBy(this.PlaceholderPartialXpath, placeholder)).SendKeys(value);
        }

        /// <summary>
        /// Click on close button of sucess message popup
        /// </summary>
        public void CloseMessagePopup()
        {
            this.WaitUntilSpinnerDisappears();
            if (!this.WaitUntilElementDisappears(this.GetBy(this.SuccessMessagePopupCloseXPath), 15))
            {
                this.ClickElement(this.GetBy(this.SuccessMessagePopupCloseXPath));
            }
        }

        /// <summary>
        /// Click on the logo icon
        /// </summary>
        public void ClickLogoIcon()
        {
            this.ClickElement(PageLoadElement);
        }

      
        public bool IsButtonEnabledInTestingPage(String buttonname)
        {
            if (this.WaitUntilElementAppears(this.GetBy(this.ButtonPartialXPath, buttonname), 5))
            {
                var button = this.FindElement(this.GetBy(this.ButtonPartialXPath, buttonname), 2);
                return button.Enabled;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
