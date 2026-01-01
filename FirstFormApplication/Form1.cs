using System.Diagnostics;
using BookManager;

namespace FirstFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Text = "도서관 관리";
            
            // label setting
            label5.Text = DataManager.Books.Count.ToString();
            label6.Text = DataManager.Users.Count.ToString();
            label7.Text = DataManager.Books.Where((x) => x.isBorrowed).Count().ToString();
            label8.Text = DataManager.Books.Where((x) =>
            {
                return x.isBorrowed && x.BorrowedAt.AddDays(7) < DateTime.Now;
            }).Count().ToString();
            
            dataGridView1.DataSource = DataManager.Books;
            dataGridView2.DataSource = DataManager.Users;
            dataGridView1.CurrentCellChanged += DataGridView1_CurrentCellChanged;
            dataGridView2.CurrentCellChanged += DataGridView2_CurrentCellChanged;

            button1.Click += Button1_Click;
            button2.Click += Button2_Click;
        }

        private void DataGridView1_CurrentCellChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;
            try
            {
                Book book = dataGridView1.CurrentRow.DataBoundItem as Book;
                textBox1.Text = book.Isbn;
                textBox2.Text = book.Name;
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }
        
        private void DataGridView2_CurrentCellChanged(object? sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null) return;
            try
            {
                User user = dataGridView2.CurrentRow.DataBoundItem as User;
                textBox3.Text = user.Id.ToString();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else if (textBox3.Text.Trim() == "")
            {
                MessageBox.Show("사용자 ID를 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {
                        MessageBox.Show("이미 대여 중인 도서입니다.");
                    }
                    else
                    {
                        User user = DataManager.Users.Single((x) => x.Id.ToString() == textBox3.Text);
                        book.UserId = user.Id;
                        book.UserName = user.Name;
                        book.isBorrowed = true;
                        book.BorrowedAt = DateTime.Now;
                        
                        // 데이터 새로고침
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();

                        MessageBox.Show($"{book.Name} 이 {user.Name} 님께 대여되었습니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }
        
        private void Button2_Click(object? sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("Isbn을 입력해주세요");
            }
            else
            {
                try
                {
                    Book book = DataManager.Books.Single((x) => x.Isbn == textBox1.Text);
                    if (book.isBorrowed)
                    {                      
                        if (book.BorrowedAt.AddDays(7) >= DateTime.Now)
                        {
                            MessageBox.Show($"{book.Name}이 반납되었습니다.");
                        }
                        else
                        {
                            MessageBox.Show($"{book.Name}이 연체 상태로 반납되었습니다.");
                        }

                        book.UserId = 0;
                        book.UserName = "";
                        book.isBorrowed = false;
                        book.BorrowedAt = new DateTime();

                        // 데이터 새로고침
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = DataManager.Books;
                        DataManager.Save();
                    }
                    else
                    {
                        MessageBox.Show("대여 상태가 아닙니다.");
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("존재하지 않는 도서 또는 사용자입니다.");
                }
            }
        }

        private void 도서관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DataManager.Books;
        }

        private void 사용자관리ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form3().ShowDialog();
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DataManager.Users;
        }
    }
}
