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
using ReFitPatientBusiness;

namespace ReFitPatientCore
{
    /// <summary>
    /// Interaction logic for CommentExerciseWindow.xaml
    /// </summary>
    public partial class CommentExerciseWindow : Window
    {
        private ExerciseControl _exerciseControl;
        /// <summary>
        /// constuctor til commentExcerciseWindow
        /// </summary>
        public CommentExerciseWindow()
        {
            _exerciseControl = new ExerciseControl();
            InitializeComponent();
        }
        /// <summary>
        /// når der trykkes gem, bør den sende notatet videre til exercisecontrol(dette er ikke implemnenteret) og lukke vinduet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gemB_Click(object sender, RoutedEventArgs e)
        {
            //_exerciseControl.SaveIsPressed(kommentarTB.Text);
            this.Close();
        }
        /// <summary>
        /// når der trykkes annuller lukker dette vindue
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void annullerB_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CommentExerciseWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }
    }
}