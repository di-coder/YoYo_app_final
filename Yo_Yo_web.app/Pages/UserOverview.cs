using Microsoft.JSInterop;
using System.Collections.Generic;
using System.Threading.Tasks;
using Yo_Yo_web.shared;
using System;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace Yo_Yo_web.app.Pages
{
    public partial class UserOverview
    {
        public string btn { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitializeUsers();
            return base.OnInitializedAsync();
        }
        public IEnumerable<User> Users { get; set; }

        private void InitializeUsers()
        {
            var user1 = new User
            {
                Id = 1,
                Name = "ABC",
                ShuttleNumber = 0,
                SpeedLevel = 0
            }; var user2 = new User
            {
                Id = 2,
                Name = "DEF",
                ShuttleNumber = 0,
                SpeedLevel = 0
            }; var user3 = new User
            {
                Id = 3,
                Name = "GHI",
                ShuttleNumber = 0,
                SpeedLevel = 0
            };
            Users = new List<User> { user1, user2, user3 };
        }
        async Task StartFunction()
        {
           List<YoYo> result = null;
            using (StreamReader r = File.OpenText(@"E:\Yo_Yo_web.app\fitnessrating_beeptest.json"))
            {
                string json = r.ReadToEnd();
                        result = JsonConvert.DeserializeObject<List<YoYo>>(json);
            }
                await JSRuntime.InvokeVoidAsync(identifier: "createfunction",args:result);
        }
        async Task EndFunction(User user)
        {
            await JSRuntime.InvokeVoidAsync(identifier: "closefunction", args: user);
        }
        async Task CountFunction(User user)
        {
            await JSRuntime.InvokeVoidAsync(identifier: "cntFunction", args: user);
        }
        async Task EditUser(User user)
        {
            await JSRuntime.InvokeVoidAsync(identifier: "EditFunction", args: user);
        }
        async Task showButtons()
        {
            await JSRuntime.InvokeVoidAsync(identifier: "ButtonsShow");
        }



    }
}




