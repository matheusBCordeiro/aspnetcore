// <auto-generated/>
#pragma warning disable 1591
namespace Test
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
    public class TestComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenComponent<Test.MyComponent>(0);
            builder.AddAttribute(1, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(2, "Hi!");
            }
            ));
            builder.AddAttribute(3, "Footer", (Microsoft.AspNetCore.Components.RenderFragment)((builder2) => {
                builder2.AddContent(4, "bye!");
            }
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
