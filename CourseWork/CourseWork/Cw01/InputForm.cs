using System;
using System.Windows.Forms;
using Cw01;

namespace ApartmentExchange
{
    public partial class InputForm : Form
    {
        public InputForm(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        /// <summary>
        /// Получение созданной заявки.
        /// </summary>
        /// <returns>Объект ExchangeApplication.</returns>
        public ExchangeApplication GetApplication()
        {
            int ownedRooms = int.Parse(ownedRoomsTextBox.Text);
            double ownedArea = double.Parse(ownedAreaTextBox.Text);
            int ownedFloor = int.Parse(ownedFloorTextBox.Text);
            string ownedDistrict = ownedDistrictTextBox.Text;

            int requiredRooms = int.Parse(requiredRoomsTextBox.Text);
            double requiredArea = double.Parse(requiredAreaTextBox.Text);
            int requiredFloor = int.Parse(requiredFloorTextBox.Text);
            string requiredDistrict = requiredDistrictTextBox.Text;

            Apartment owned = new Apartment(ownedRooms, ownedArea, ownedFloor, ownedDistrict);
            Apartment required = new Apartment(requiredRooms, requiredArea, requiredFloor, requiredDistrict);

            return new ExchangeApplication(surnameTextBox.Text, owned, required);
        }

        // Обработчик кнопки "OK"
        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Валидация
                if (string.IsNullOrWhiteSpace(surnameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(ownedDistrictTextBox.Text) ||
                    string.IsNullOrWhiteSpace(requiredDistrictTextBox.Text))
                {
                    throw new Exception("Все текстовые поля должны быть заполнены.");
                }

                int ownedRooms = int.Parse(ownedRoomsTextBox.Text);
                double ownedArea = double.Parse(ownedAreaTextBox.Text);
                int ownedFloor = int.Parse(ownedFloorTextBox.Text);

                int requiredRooms = int.Parse(requiredRoomsTextBox.Text);
                double requiredArea = double.Parse(requiredAreaTextBox.Text);
                int requiredFloor = int.Parse(requiredFloorTextBox.Text);

                if (ownedRooms <= 0 || ownedArea <= 0 || ownedFloor <= 0 ||
                    requiredRooms <= 0 || requiredArea <= 0 || requiredFloor <= 0)
                {
                    throw new Exception("Числовые значения должны быть положительными.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный формат чисел. Используйте целые для комнат/этажа, вещественные для площади.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Обработчик кнопки "Cancel"
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}