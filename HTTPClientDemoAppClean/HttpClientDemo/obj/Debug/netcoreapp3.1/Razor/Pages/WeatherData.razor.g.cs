#pragma checksum "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cab01a8b28778a31720aa9213cc563fae2a1c491"
// <auto-generated/>
#pragma warning disable 1591
namespace HttpClientDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using HttpClientDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using HttpClientDemo.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\_Imports.razor"
using HttpClientDemo.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class WeatherData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>WeatherData</h3>\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
 if (string.IsNullOrWhiteSpace(errorString) == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "h2");
            __builder.AddContent(4, 
#nullable restore
#line 9 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
                     errorString

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n");
#nullable restore
#line 10 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
}
else if (forecast is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.AddMarkupContent(7, "<div class=\"h4\">Loading...</div>\r\n");
#nullable restore
#line 14 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table table-striped");
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.AddMarkupContent(11, "<thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>Date</th>\r\n            <th>Weather</th>\r\n            <th>Low</th>\r\n            <th>High</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(12, "tbody");
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 27 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
         foreach (var w in forecast.Consolidated_weather)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 30 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
                 w.applicable_date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 31 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
                 w.weather_state_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 32 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
                 w.min_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "td");
            __builder.AddContent(27, 
#nullable restore
#line 33 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
                 w.max_temp

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
#nullable restore
#line 35 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#nullable restore
#line 38 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Present\RiderProjects\HttpClientDemoApp\HttpClientDemo\Pages\WeatherData.razor"
           
    WeatherForecastModel forecast;
    string errorString;

    protected override async Task OnInitializedAsync()
    {
        //var request = new HttpRequestMessage(HttpMethod.Get,
        //    "https://www.metaweather.com/api/location/968019/");

        //var client = _clientFactory.CreateClient();

        //HttpResponseMessage response = await client.SendAsync(request);

        //if (response.IsSuccessStatusCode)
        //{
        //    forecast = await response.Content.ReadFromJsonAsync<WeatherForecastModel>();
        //    errorString = null;
        //}
        //else
        //{
        //    errorString = $"There was an error getting our forecast:{ response.ReasonPhrase}";
        //}

        var client = _clientFactory.CreateClient();

        try
        {
            forecast = await client.GetFromJsonAsync<WeatherForecastModel>("https://www.metaweather.com/api/location/968019/");
            errorString = null;
        }
        catch (Exception ex)
        {

            errorString = $"There was an error getting our forecast:{ ex.Message }";
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory _clientFactory { get; set; }
    }
}
#pragma warning restore 1591
