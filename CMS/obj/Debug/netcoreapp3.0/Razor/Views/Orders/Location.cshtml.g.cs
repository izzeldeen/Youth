#pragma checksum "E:\Youth\AlamanehYoghurt\CMS\Views\Orders\Location.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43a11ab8d01f45c9dcbbccb59f857a892443f722"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Location), @"mvc.1.0.view", @"/Views/Orders/Location.cshtml")]
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
#line 1 "E:\Youth\AlamanehYoghurt\CMS\Views\_ViewImports.cshtml"
using CMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Youth\AlamanehYoghurt\CMS\Views\_ViewImports.cshtml"
using CMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43a11ab8d01f45c9dcbbccb59f857a892443f722", @"/Views/Orders/Location.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fda46ac6a24f19109ebb784fda558b061b2e80b", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Location : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CMS.Models.LocationModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Begin Page Content -->
<div class=""container-fluid"">

    <!-- Page Heading -->
    <div class=""d-sm-flex align-items-center justify-content-between mb-4"">
        <h1 class=""h3 mb-0 text-gray-800"">Orders</h1>
    </div>

    <div class=""row"">

        <div class=""col-lg-12"">
            <!-- Basic Card Example -->
            <div class=""card shadow mb-4"">
                <div class=""card-header py-3"">
                    <h6 class=""m-0 font-weight-bold text-primary"">View Order Location</h6>
                </div>
                <div class=""card-body"">
                    <div id=""map"" style=""display:block; height: 500px; width:100%""></div>
                </div>
            </div>
        </div>

    </div>

</div>
<!-- /.container-fluid -->



<script>
    function initMap() {

        var map = new google.maps.Map(document.getElementById('map'), {
            center: { lat: 31.963158, lng: 35.930359 },
            zoom: 6
        });

        var locationObj;

");
            WriteLiteral("        locationObj = { lat: ");
#nullable restore
#line 41 "E:\Youth\AlamanehYoghurt\CMS\Views\Orders\Location.cshtml"
                        Write(Model.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(", lng: ");
#nullable restore
#line 41 "E:\Youth\AlamanehYoghurt\CMS\Views\Orders\Location.cshtml"
                                              Write(Model.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" };

            var marker = new google.maps.Marker({
                position: locationObj,
                map: map
            });

        google.maps.event.addListener(marker, 'click', function() {
            map.panTo(this.getPosition());
            map.setZoom(16);
        }); 
    }
</script>
<script src=""https://maps.googleapis.com/maps/api/js?key=AIzaSyC5gvN50xPVuO3Fp6sABCumYv7M53PeaLE&callback=initMap""
        async defer></script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CMS.Models.LocationModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
