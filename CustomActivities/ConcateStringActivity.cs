using System;
using System.Activities;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomActivities
{
    public class ConcateStringActivity : CodeActivity
    {
        [Category("Input")]
        [RequiredArgument]
        public InOutArgument<string> FirstString { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public InOutArgument<string> SecondString { get; set; }

        [Category("Input")]
        [RequiredArgument]
        public OutArgument<string> Result { get; set; }

        protected override void Execute(CodeActivityContext context)
        {
            var firstString = FirstString.Get(context);
            var secondString = SecondString.Get(context);

            var result = ConcatString(firstString, secondString);
            
            Result.Set(context, result);
        }

        public string ConcatString(string firstString, string secondString)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(firstString);
            sb.Append(" ");
            sb.Append(secondString);
            var result = sb.ToString();
            return result;
        }
    }
}
