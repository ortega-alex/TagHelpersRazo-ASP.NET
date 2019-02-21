using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TagHelpersRazo.TagHelpers
{

    [HtmlTargetElement(Attributes = nameof(Condition))]
    public class ConditionTagHelpers : TagHelper
    {
        public bool Condition { get; set;  }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!Condition)
            {
                output.SuppressOutput();
            }
        }
    }
}
