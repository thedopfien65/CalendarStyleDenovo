#pragma checksum "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LeadTechSchedule), @"mvc.1.0.view", @"/Views/Home/LeadTechSchedule.cshtml")]
namespace AspNetCore
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
#line 1 "C:\demoCode\CalendarTest\Views\_ViewImports.cshtml"
using CalendarTest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\demoCode\CalendarTest\Views\_ViewImports.cshtml"
using CalendarTest.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb", @"/Views/Home/LeadTechSchedule.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74c9da8507b5199164f4e322eb4c922e6078c7b", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_LeadTechSchedule : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LeadTechDashViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/fullcalendar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/acb_scheduler_bryan.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/fullcalendar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/acb_ltDashboard_bryan.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            DefineSection("css", async() => {
                WriteLiteral("\r\n\t<!--Plugins-->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb5249", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<!-- ACB CSS -->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb6447", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral(@"<!--breadcrumb start-->
<div class=""page-breadcrumb d-none d-sm-flex align-items-center mb-3"">
	<div class=""breadcrumb-title pe-3"">Duty App</div>
	<div class=""ps-3"">
		<nav aria-label=""breadcrumb"">
			<ol class=""breadcrumb mb-0 p-0"">
				<li class=""breadcrumb-item""><a href=""javascript:;""><i class=""bx bx-home-alt""></i></a>
				</li>
				<li class=""breadcrumb-item active"" aria-current=""page"">Lead Tech Dashboard</li>
			</ol>
		</nav>
	</div>				
</div>
<!--end breadcrumb-->
			
<!--Scheduler Module Content-->
<div class=""lead-tech-content-wrapper lead-tech-dash-wrapper"">
	<div class=""lt-dash-mobile-tab-toolbar"" id=""lt-dash-mobile-toolbar"">
		<div class=""lt-dash-mobile-tab-control mtc-active"" id=""mtc-overview"">Overview</div>
		<div class=""lt-dash-mobile-tab-control"" id=""mtc-reassign"">Reassignments</div>
		<div class=""lt-dash-mobile-tab-control"" id=""mtc-techs"">Techs</div>
	</div>
					
	<div class=""row"">
					
		<div class=""col col-md-8 col-12 lt-dash-col lt-dash-calendar-col"">
			<div c");
            WriteLiteral(@"lass=""lt-calendar lt-dash-calendar"" id=""lt-dash-calendar-display"" >
				<div class=""card"">
					<div class=""card-body"">
						<div class=""table-responsive"">
							<div id='calendar'></div>
						</div>
					</div>
				</div>
			</div>
			<div class=""row lt-timeslot-viewer"">
				<div class=""col col-md-6 col-12 lt-timeslot-list lt-mobile-hide-forever"" id=""lt-timeslot-list"">
					<div class=""card"">
						<div class=""card-header lt-task-list-title"">
							<h3 id=""task-list-title-text"">Thursday, May 12, 2022</h3>
						</div>
						<div class=""card-body"" id=""lt-dash-day-timeslot-list"">
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#timeslot-collapse-1"">10AM - 1 Appointment</button>
								<div class=""collapse lt-timeslot-techs-collapse"" id=""timeslot-collapse-1"">
									<div class=""lt-tech-appointment-button"" data-appt-id=""1"">Tech 1 | Client Name | City/Address</div>
								</d");
            WriteLiteral(@"iv>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#timeslot-collapse-2"">11AM - 4 Appointments</button>
								<div class=""collapse lt-timeslot-techs-collapse"" id=""timeslot-collapse-2"">
									<div class=""lt-tech-appointment-button"" data-appt-id=""2"">Tech 2 | Client Name | City/Address</div>
									<div class=""lt-tech-appointment-button"" data-appt-id=""3"">Tech 4 | Client Name | City/Address</div>
									<div class=""lt-tech-appointment-button"" data-appt-id=""4"">Tech 5 | Client Name | City/Address</div>
									<div class=""lt-tech-appointment-button"" data-appt-id=""5"">Tech 8 | Client Name | City/Address</div>
								</div>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#timeslot-collapse-3"">1PM - 1 Appointments</button>
								<div class=""coll");
            WriteLiteral(@"apse lt-timeslot-techs-collapse"" id=""timeslot-collapse-3"">
									<div class=""lt-tech-appointment-button"" data-appt-id=""6"">Tech 3 | Client Name | City/Address</div>
								</div>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#timeslot-collapse-4"">2PM - 1 Appointment</button>
								<div class=""collapse lt-timeslot-techs-collapse"" id=""timeslot-collapse-4"">
									<div class=""lt-tech-appointment-button"" data-appt-id=""7"">Tech 6 | Client Name | City/Address</div>
								</div>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#timeslot-collapse-5"">4PM - 2 Appointments</button>
								<div class=""collapse lt-timeslot-techs-collapse"" id=""timeslot-collapse-5"">
									<div class=""lt-tech-appointment-button"" data-appt-id=""8"">Tech 7 | Client Name | ");
            WriteLiteral(@"City/Address</div>
									<div class=""lt-tech-appointment-button"" data-appt-id=""9"">Tech 9 | Client Name | City/Address</div>
								</div>
							</div>
						</div>
					</div>
				</div>
				<!--Timeslot view for mobile displays-->
				<div class=""col col-md-6 col-12 lt-timeslot-list lt-desktop-hide"" id=""lt-timeslot-list-mobile"">
					<div class=""card"">
						<div class=""card-header lt-task-list-title"">
							<h3>Thursday, May 12, 2022: 11AM</h3>
						</div>
						<div class=""card-body"">
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button timeslot-detail-button-mobile"" type=""button"">Tech 1 - Client Name</button>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button timeslot-detail-button-mobile"" type=""button"">Tech 4 - Client Name</button>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button timeslot-detail-");
            WriteLiteral(@"button-mobile"" type=""button"">Tech 5 - Client Name</button>
							</div>
							<div class=""lt-timeslot-display"">
								<button class=""btn btn-primary timeslot-detail-button timeslot-detail-button-mobile"" type=""button"">Tech 7 - Client Name</button>
							</div>
						</div>
						<div class=""card-footer"">
							<button class=""btn btn-secondary timeslot-display-back"" id=""timeslot-display-back-btn"" type=""button"">Go Back</button>
						</div>
					</div>
				</div>
				<!--End Timeslot View for Mobile Displays-->
				<div class=""col col-md-6 col-12 lt-timeslot-details lt-mobile-hide"" id=""lt-appt-details"">
					<div class=""lt-timeslot-detail-viewer"">
										
						<div class=""card"">
							<div class=""card-header"">
								<h4 id=""lt-dash-appt-time"">11AM</h4>
								<h6 id=""lt-dash-appt-assignee"">Tech 4</h6>
							</div>
							<div class=""card-body"">
								<div class=""row lt-timeslot-detail-container"">
									<div class=""col lt-dash-appt-client-details"">
										<h6 class=""l");
            WriteLiteral(@"t-dash-client-info-title"" id=""dash-client-title"">Client Info</h6>
										<p class=""lt-dash-client-name"" id=""dash-client-name"">Bryan Burnham</p>
										<p class=""lt-dash-client-address"" id=""dash-client-address"">123 Fake Street</br>Nowhere, US 00000</p>
										<p class=""lt-dash-client-note"" id=""dash-client-note"">Note: Client requested spanish speaking, if possible.</p>
									</div>
									<div class=""col lt-dash-appt-equipment"">
										<h6 class=""lt-dash-equipment-title"">Equipment</h6>
										<ul id=""lt-dash-equipment"">
											<li class=""lt-dash-equipment-item"">Door Alarm</li>
											<li class=""lt-dash-equipment-item"">Outdoor Camera (2)</li>
											<li class=""lt-dash-equipment-item"">Automated Flamethrower Sentry (2)</li>
											<li class=""lt-dash-equipment-item"">Heads on Spikes (7)</li>
											<li class=""lt-dash-equipment-item"">Polite Warning Sign (4)</li>
										</ul>
									</div>
								</div>
							</div>
							<div class=""card-footer"">
					");
            WriteLiteral(@"			<a href=""TechReassignmentForm/1""><button class=""btn btn-secondary reassign-link-button"">Reassign This Appointment</button></a>
								<button class=""btn btn-secondary appt-detail-back lt-back-button-desktop-hide"" id=""appt-detail-back-btn"" type=""button"">Go Back</button>
							</div>
						</div>
					</div>
				</div>
			</div>
		</div>
						
		<div class=""col col-md-4 col-12 lt-dash-col lt-dash-tasks-col"">
			<div class=""lt-task-list lt-urgent-reassign lt-mobile-hide"" id=""lt-pending-assignments"">								
				<div class=""card"">
					<div class=""card-header lt-task-list-title"">
						<h3>Pending Reassignment Requests</h3>
					</div>
					<div class=""card-body"">
");
#nullable restore
#line 162 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                         foreach(var appt in Model.PendingAppts) 
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"lt-pending-reassign-display\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t<span class=\"lt-pending-reassign-item lt-pending-reassign-date\">");
#nullable restore
#line 165 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                                       Write(appt.Timeslot.ToString("MM-dd-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t<span class=\"lt-pending-reassign-item lt-pending-reassign-time\">");
#nullable restore
#line 166 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                                       Write(appt.Timeslot.ToString("htt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t<span class=\"lt-pending-reassign-item lt-pending-reassign-tech\">");
#nullable restore
#line 167 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                                       Write(appt.Assignee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t<span class=\"lt-pending-reassign-item lt-pending-reassign-client\">");
#nullable restore
#line 168 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                                         Write(appt.ClientName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 170 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
						}									

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					</div>
					<div class=""card-footer lt-reassignment-controls"">
						<button disabled class=""btn btn-secondary"" id=""reassign-appt""><a id=""reassign-appt-link"" href=""TechReassignmentForm"">Reassign Appointment</a></button>
						<button class=""btn btn-secondary"">See All</button>
					</div>
				</div>
			</div>
							
			<div class=""lt-task-list lt-team-members lt-mobile-hide"" id=""lt-team-list"">						
				<div class=""card"">
					<div class=""card-header lt-task-list-title"">
						<h3>Team</h3>
					</div>
					<div class=""card-body"">
");
#nullable restore
#line 185 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                         foreach(var tech in Model.TechTeam) 
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"lt-team-member-display\" tabindex=\"0\">\r\n\t\t\t\t\t\t\t<span class=\"lt-team-member-item lt-team-member-name\">");
#nullable restore
#line 188 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                             Write(tech.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t<span class=\"lt-team-member-item lt-team-member-appts\">");
#nullable restore
#line 189 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
                                                                              Write(tech.NumAppts);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Assignments</span>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 191 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
						}			

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					</div>
					<div class=""card-footer lt-team-member-controls"">
						<button disabled class=""btn btn-secondary"" id=""view-tech-schedule""><a id=""tech-schedule-link"" href=""TechSchedule"">View Tech Schedule</a></button>
						<button class=""btn btn-secondary"">See All</button>
					</div>
				</div>
			</div>
		</div>
	</div>
</div>				
<!--End Scheduler Content-->
");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t<!--Plugins-->\r\n\t<script type=\"text/javascript\" src=\"//cdn.jsdelivr.net/momentjs/latest/moment.min.js\"></script> \r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb20562", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<!--ACB JS-->\r\n\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5fd4e1aaea11b4ed55f2a9c515ddf2d1bb5872cb21679", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#nullable restore
#line 209 "C:\demoCode\CalendarTest\Views\Home\LeadTechSchedule.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t<script>\r\n\t$(document).ready(function(){\r\n\t\tinitCalendar();\r\n\t\tinitLeadTechView();\r\n\t});\r\n\t</script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LeadTechDashViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
