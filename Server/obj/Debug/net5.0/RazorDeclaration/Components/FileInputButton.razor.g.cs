// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Remotely.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Hubs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Shared.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Components.Devices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Shared.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Components.TabControl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using System.Collections.Concurrent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Components.Scripts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\_Imports.razor"
using Remotely.Server.Components.TreeView;

#line default
#line hidden
#nullable disable
    public partial class FileInputButton : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\HP ELITEBOOK 840G3\Source\Repos\aruntomy98\RmFi\Server\Components\FileInputButton.razor"
       
    [Parameter]
    public string ClassNames { get; set; }

    [Parameter]
    public RenderFragment ButtonContent { get; set; }


    [Parameter]
    public Func<InputFileChangeEventArgs, Task> OnChanged { get; set; }

    [Parameter]
    public bool Multiple { get; set; }

    private readonly string _hiddenInputId = $"input-{Guid.NewGuid()}";


    private async Task OnFileChanged(InputFileChangeEventArgs args)
    {
        if (OnChanged is not null)
        {
            await OnChanged.Invoke(args);
        }
    }

    private void OpenFilePicker()
    {
        JsInterop.InvokeClick(_hiddenInputId);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJsInterop JsInterop { get; set; }
    }
}
#pragma warning restore 1591
