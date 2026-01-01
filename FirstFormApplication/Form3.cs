using BookManager;

namespace FirstFormApplication;

public partial class Form3 : Form
{
    public Form3()
    {
        InitializeComponent();
        Text = "사용자 관리";
        
        dataGridView1.DataSource = DataManager.Users;
        dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;

        button1.Click += (sender, args) =>
        {
            try
            {
                if (DataManager.Users.Exists((x) => x.Id == int.Parse(textBox1.Text)))
                {
                    MessageBox.Show("사용자 ID가 중복되었습니다.");
                }
                else
                {
                    User user = new User()
                    {
                        Id = int.Parse(textBox1.Text),
                        Name = textBox2.Text
                    };
                    
                    DataManager.Users.Add(user);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = DataManager.Users;
                    DataManager.Save();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        };
        
        button2.Click += (sender, args) =>
        {
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                user.Name = textBox2.Text;

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception e)
            {
                MessageBox.Show("존재하지 않는 사용자 입니다.");
                throw;
            }
        };
        
        button3.Click += (sender, args) =>
        {
            try
            {
                User user = DataManager.Users.Single((x) => x.Id == int.Parse(textBox1.Text));
                DataManager.Users.Remove(user);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = DataManager.Users;
                DataManager.Save();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        };
    }
    
    private void DataGridView1_CurrentCellChanged(object? sender, EventArgs e)
    {
        if (dataGridView1.CurrentRow == null) return;
        try
        {
            User user = dataGridView1.CurrentRow.DataBoundItem as User;
            textBox1.Text = user.Id.ToString();
            textBox2.Text = user.Name;
        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
}