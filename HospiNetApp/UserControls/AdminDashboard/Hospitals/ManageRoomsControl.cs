using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospiNetApp.UserControls.AdminDashboard.Hospitals
{
    public partial class ManageRoomsControl : UserControl
    {
        public ManageRoomsControl()
        {
            InitializeComponent();
        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {
            AddRoomControl oControl = new AddRoomControl();
            MainControl.showControl(oControl, panel_ManageRooms);
        }

        /// <summary>
        /// API call to get all rooms and inserts them in dataGridView_Rooms
        /// </summary>
        public async void GetRooms()
        {
            label_loading.Visible = true;

            try
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri($"https://localhost:44310/api/hospitals/GetAllRooms");
                    var response = await client.GetAsync(client.BaseAddress);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = response.Content.ReadAsStringAsync().Result;
                        List<Models.ModRoom> lstContent = JsonConvert.DeserializeObject<List<Models.ModRoom>>(content);

                        int i = 0;

                        foreach (var room in lstContent)
                        {
                            dataGridView_Rooms.Rows.Insert(i, room.RoomName, room.HospitalName);
                            i++;
                        }

                        label_loading.Visible = false;
                        dataGridView_Rooms.Visible = true;
                    }
                }
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
