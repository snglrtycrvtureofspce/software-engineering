using Cw01.Classes;

namespace Cw01.Forms;

public partial class InputForm : Form
{
    public InputForm(string title)
    {
        InitializeComponent();
        Text = title;
    }

    /// <summary>
    /// Получение созданной заявки.
    /// </summary>
    /// <returns>Объект ExchangeApplication.</returns>
    public ExchangeApplication GetApplication()
    {
        var ownedRooms = int.Parse(ownedRoomsTextBox.Text);
        var ownedArea = double.Parse(ownedAreaTextBox.Text);
        var ownedFloor = int.Parse(ownedFloorTextBox.Text);
        var ownedDistrict = ownedDistrictTextBox.Text;

        var requiredRooms = int.Parse(requiredRoomsTextBox.Text);
        var requiredArea = double.Parse(requiredAreaTextBox.Text);
        var requiredFloor = int.Parse(requiredFloorTextBox.Text);
        var requiredDistrict = requiredDistrictTextBox.Text;

        var owned = new Apartment(ownedRooms, ownedArea, ownedFloor, ownedDistrict);
        var required = new Apartment(requiredRooms, requiredArea, requiredFloor, requiredDistrict);

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

            var ownedRooms = int.Parse(ownedRoomsTextBox.Text);
            var ownedArea = double.Parse(ownedAreaTextBox.Text);
            var ownedFloor = int.Parse(ownedFloorTextBox.Text);

            var requiredRooms = int.Parse(requiredRoomsTextBox.Text);
            var requiredArea = double.Parse(requiredAreaTextBox.Text);
            var requiredFloor = int.Parse(requiredFloorTextBox.Text);

            if (ownedRooms <= 0 || ownedArea <= 0 || ownedFloor <= 0 ||
                requiredRooms <= 0 || requiredArea <= 0 || requiredFloor <= 0)
            {
                throw new Exception("Числовые значения должны быть положительными.");
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        catch (FormatException)
        {
            MessageBox.Show(
                "Некорректный формат чисел. Используйте целые для комнат/этажа, вещественные для площади.",
                "Ошибка",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    // Обработчик кнопки "Cancel"
    private void CancelButton_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Cancel;
        Close();
    }
}