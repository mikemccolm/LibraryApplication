#pragma checksum "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0ba2a720382ea9772dedc8d659788136ca322d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(LibraryApplication.Pages.Pages_Checkout), @"mvc.1.0.razor-page", @"/Pages/Checkout.cshtml")]
namespace LibraryApplication.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\_ViewImports.cshtml"
using LibraryApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using MailKit.Net.Smtp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using MailKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using MimeKit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using FireSharp.Config;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using FireSharp.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
using FireSharp.Response;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0ba2a720382ea9772dedc8d659788136ca322d1", @"/Pages/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d8ba76c81e21604f1ad934a3db2a350d4b32be1", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Checkout : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2 class = \"text-center\">LIBRARY APPLICATION - Checkout</h2>\r\n<hr/>\r\n<div class = \"text-right\">\r\n<p>");
#nullable restore
#line 118 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
Write(Model.emailMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0ba2a720382ea9772dedc8d659788136ca322d15538", async() => {
                WriteLiteral(@" 
    <div class = ""text-center"">
    <!-- Login/logout -->
        <h5>Take out/return books:</h5>
        <label>Return ID:</label>
        <input type = ""text"" name = ""returnId""/>
        <button>Submit</button>
        <br/>
        <label>Checkout ID:</label>
        <input type = ""text"" name = ""takeoutId""/>
        <button>Submit</button>
        <p>");
#nullable restore
#line 131 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
      Write(Model.returnIdMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p>");
#nullable restore
#line 132 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
      Write(Model.takeoutIdMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "C:\Users\mikem\Documents\home\GITSTUFF\LibraryApplication\Pages\Checkout.cshtml"
            
    public class Book{
        public string id = "";
        public string status = "";
        public string title = "";
        public string author = "";
        public string history = "";
        public void setVals(string idIn, string titleIn, string authorIn, string statusIn, string historyIn){
            id = idIn;
            title = titleIn;
            history = historyIn;
            author = authorIn;
            status = statusIn;
        }

    }
    public class IndexModel : PageModel
    {
        public string email {get;set;} = "";
        public string returnIdMessage{get;set;} = "";
        public string takeoutIdMessage{get;set;} = "";
        public string emailMessage { get; set; } = "Logged in as: NONE";

        public void OnGetAsync(){
            email = HttpContext.Session.GetString("_Email");
            emailMessage = $"Logged in as: {email}"; 
        }
        public void OnPostEdit(string takeoutId, string returnId)
        {
            email = HttpContext.Session.GetString("_Email");
            emailMessage = $"Logged in as: {email}";
            //take out/return
            if (!String.IsNullOrEmpty(email)){
                returnBook(returnId, takeoutId);
            } 
        }
        public void sendEmail(string title, string email){
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Library-Application","emailsender974@gmail.com"));
            message.To.Add(new MailboxAddress("User", "booleafs17@yahoo.ca")); //change this to email
            message.Subject = "Book Notification";
            message.Body = new TextPart("plain"){
                Text = "You took out the following book: " + title + ". Please return it within 7 days."
            };

            using (var client = new SmtpClient()){
                client.Connect("smtp.gmail.com",587,false);
                client.Authenticate("emailsender974@gmail.com","emailsend");
                client.Send(message);
                client.Disconnect(true);
            }
        }

        
        public async Task returnBook(string returnId, string takeoutId){
            IFirebaseConfig config = new FirebaseConfig
            {
                AuthSecret = "1YwwPshIwO1oaE0PgpyCJc7cG5CMezZovmE7TDTw",
                BasePath = "https://library-application-5c7df.firebaseio.com/"
            };
            IFirebaseClient client;
            client = new FireSharp.FirebaseClient(config);
            if(!String.IsNullOrEmpty(returnId)){
                try{
                    returnIdMessage = $"(Successfully returned #{returnId})";
                    FirebaseResponse response = await client.GetAsync("Books/"+returnId);
                    Book obj = response.ResultAs<Book>();
                    //(string idIn, string titleIn, string authorIn, string statusIn, string historyIn)
                    string id = obj.id;
                    string status = "";
                    string author = obj.author;
                    string title = obj.title;
                    string history = obj.history + ", Returned: " + DateTime.Now + " | ";
                    Book b1 = new Book();
                    b1.setVals(id,status,author,title,history);
                    await client.SetAsync("Books/"+returnId,b1);
                }
                catch(NullReferenceException ex){
                    returnIdMessage = "Could not find record";
                }

            }
            if(!String.IsNullOrEmpty(takeoutId)){
                takeoutIdMessage = $"(Successfully took out #{takeoutId})";
                FirebaseResponse response = await client.GetAsync("Books/"+takeoutId);
                Book obj = response.ResultAs<Book>();
                if(String.IsNullOrEmpty(obj.status)){
                    string id = obj.id;
                    string status = email;
                    string author = obj.author;
                    string title = obj.title;
                    string history = obj.history + " User: " + email + ", Taken Out: " + DateTime.Now; 
                    Book b1 = new Book();
                    b1.setVals(id,status,author,title,history);
                    await client.SetAsync("Books/"+takeoutId,b1);
                    sendEmail(title, email);
                    }

            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
