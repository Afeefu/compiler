using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
namespace newcompilerproject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonValidate_Click(object sender, EventArgs e)
        {
            string input = textBoxInput.Text;

            try
            {
                // إعداد Lexer و Parser
                AntlrInputStream inputStream = new AntlrInputStream(input);
                ExpressionLexer lexer = new ExpressionLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                ExpressionParser parser = new ExpressionParser(tokenStream);

                // استدعاء القاعدة الرئيسية
                parser.prog();

                // إذا نجح التحليل
                labelResult.Text = "Array definition is valid!";
                labelResult.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                // إذا فشل التحليل
                labelResult.Text = "Error: " + ex.Message;
                labelResult.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void labelResult_Click(object sender, EventArgs e)
        {

        }
    }
}
