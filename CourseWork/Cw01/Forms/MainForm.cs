using Cw01.Classes;

namespace Cw01.Forms;

public partial class MainForm : Form
{
    private static readonly HashSet<ExchangeApplication> CardIndex = []; // Картотека (set)

    public MainForm()
    {
        InitializeComponent();
    }

    // Обработчик кнопки "Ввод заявки"
    private void InputButton_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm("Ввод новой заявки"))
        {
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var newApp = inputForm.GetApplication();
                if (CardIndex.Add(newApp))
                {
                    MessageBox.Show(
                        "Заявка добавлена успешно.",
                        "Успех",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(
                        "Такая заявка уже существует.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
        }
    }

    // Обработчик кнопки "Поиск варианта"
    private void SearchButton_Click(object sender, EventArgs e)
    {
        using (var inputForm = new InputForm("Ввод заявки для поиска"))
        {
            if (inputForm.ShowDialog() == DialogResult.OK)
            {
                var newApp = inputForm.GetApplication();

                // Поиск совпадения
                var match = CardIndex.FirstOrDefault(app =>
                    app.OwnedApartment.Rooms == newApp.RequiredApartment.Rooms &&
                    app.RequiredApartment.Rooms == newApp.OwnedApartment.Rooms &&
                    app.OwnedApartment.Floor == newApp.RequiredApartment.Floor &&
                    app.RequiredApartment.Floor == newApp.OwnedApartment.Floor &&
                    Math.Abs(app.OwnedApartment.Area - newApp.RequiredApartment.Area) / Math.Max(app.OwnedApartment.Area, newApp.RequiredApartment.Area) <= 0.1 &&
                    Math.Abs(app.RequiredApartment.Area - newApp.OwnedApartment.Area) / Math.Max(app.RequiredApartment.Area, newApp.OwnedApartment.Area) <= 0.1
                );

                if (match != null)
                {
                    MessageBox.Show(
                        $"Найден подходящий вариант:\n{match}\nЗаявка удалена из картотеки.",
                        "Совпадение найдено",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CardIndex.Remove(match);
                }
                else
                {
                    if (CardIndex.Add(newApp))
                    {
                        MessageBox.Show(
                            "Совпадение не найдено. Заявка добавлена в картотеку.",
                            "Добавлено",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Такая заявка уже существует.",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }

    // Обработчик кнопки "Вывод картотеки"
    private void OutputButton_Click(object sender, EventArgs e)
    {
        if (CardIndex.Count == 0)
        {
            MessageBox.Show("Картотека пуста.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        dataGridView.Rows.Clear();
        dataGridView.Columns.Clear();

        // Настройка колонок
        dataGridView.Columns.Add("Surname", "Фамилия и инициалы");
        dataGridView.Columns.Add("OwnedRooms", "Имеющаяся: Комнаты");
        dataGridView.Columns.Add("OwnedArea", "Имеющаяся: Площадь");
        dataGridView.Columns.Add("OwnedFloor", "Имеющаяся: Этаж");
        dataGridView.Columns.Add("OwnedDistrict", "Имеющаяся: Район");
        dataGridView.Columns.Add("RequiredRooms", "Требуемая: Комнаты");
        dataGridView.Columns.Add("RequiredArea", "Требуемая: Площадь");
        dataGridView.Columns.Add("RequiredFloor", "Требуемая: Этаж");
        dataGridView.Columns.Add("RequiredDistrict", "Требуемая: Район");

        foreach (var app in CardIndex)
        {
            dataGridView.Rows.Add(app.SurnameInitials,
                app.OwnedApartment.Rooms,
                app.OwnedApartment.Area,
                app.OwnedApartment.Floor,
                app.OwnedApartment.District,
                app.RequiredApartment.Rooms,
                app.RequiredApartment.Area,
                app.RequiredApartment.Floor,
                app.RequiredApartment.District);
        }
    }

    // Обработчик кнопки "Выход"
    private void ExitButton_Click(object sender, EventArgs e)
    {
        Close();
    }
}