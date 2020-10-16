using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace REX_Project.Data
{
    public class HtmlService
    {
        [Parameter]
        public string Body { get; set; } = "asda";
        public event Action OnChange;
        public string getBody()
        {
            return Body;
        }
        public void setBody(string B)
        {
            Body=B;
            NotifyStateChanged();
        }
        private void NotifyStateChanged() => OnChange?.Invoke();


    }
}
