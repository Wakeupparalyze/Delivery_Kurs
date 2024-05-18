using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DeliveryKursApi.DTO;
using Newtonsoft.Json;

namespace Delivery_Kurs
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window 
    {
        public List<DishDTO> dishes;
        public HomeWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void BasketBtn(object sender, RoutedEventArgs e)
        {
            BasketWindow basketWindow = new BasketWindow();
            basketWindow.Show();
            Close();
        }

        private void ExitBtn(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void dishchange(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void WindowLoaded(object sender, RoutedEventArgs e)
        {
            await LoadData();
        }
        public async Task LoadData()
        {
            try
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage responseproduct = await client.GetAsync($"https://localhost:7022/api/Dish/GetAllDishes");

                if (responseproduct.IsSuccessStatusCode)
                {
                    string responseBody = await responseproduct.Content.ReadAsStringAsync();


                    dishes = JsonConvert.DeserializeObject<List<DishDTO>>(responseBody);
                    foreach (DishDTO dish in dishes)
                    {

                        listboxDishes.Items.Add(dish);
                    }

                }
                string responseBody1 = await responseproduct.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<List<DishDTO>>(responseBody1);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}
