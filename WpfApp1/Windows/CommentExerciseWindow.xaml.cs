using System;
using System.Collections.Generic;
using System.Linq;
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
using ReFitPatientCore.BusinessLogic;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for CommentExerciseWindow.xaml
    /// </summary>
    public partial class CommentExerciseWindow : Window
    {
        private ExerciseControl _exerciseControl;
        public CommentExerciseWindow(ExerciseControl exerciseControl)
        {
            _exerciseControl = exerciseControl;
            InitializeComponent();
        }

        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            _exerciseControl.SaveIsPressed(kommentarTB.Text);
            this.Close();
        }

        private void annullerB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
