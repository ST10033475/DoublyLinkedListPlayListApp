using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoublyLinkedListPlayListApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DoublyLinkedList List = new DoublyLinkedList();
        private void Previous_Click(object sender, EventArgs e)
        {
            label1.Text =List.PreviousNode(List, listBox1.SelectedItem.ToString()).ToString();
        }

        private void DeleteCurrent_Click(object sender, EventArgs e)
        {
            List.DeleteNode(List, listBox1.SelectedItem.ToString());
          listBox1.Items.Clear();
            for (int i = 0; i < List.GetCount(List); i++)
            {
                listBox1.Items.Add(List.GetNode(List, i));
            }

        }

        private void Next_Click(object sender, EventArgs e)
        {
            label1.Text = List.NextNode(List, listBox1.SelectedItem.ToString()).ToString();
        }

        private void AddTrack_Click(object sender, EventArgs e)
        {

            Track track = new Track(textBox1.Text.ToString());
            List.InsertLast(List, track);

            listBox1.Items.Add(track);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            Track track = new Track("Track 1");
            Track track1 = new Track("Track 2");
            Track track2 = new Track("Track 3");
            List.InsertLast(List, track);
            List.InsertLast(List, track1);
            List.InsertLast(List, track2);

            for (int i = 0; i <= List.GetCount(List); i++)
            {
                listBox1.Items.Add(List.GetNode(List, i));
            }
        }
        //public void InsertBetween(Object data, int index)
        //{
        //    int step = 0;
        //    Node<Object> current = head;
        //    while (step > index)
        //    {
        //        //take the new node, make newNode.next= current.next, newnode.current= current. then say curren.next = newnode
        //        //newnode.next = current.next;
        //        //newnode.prev = current
        //        //current.next = newnode
        //        //newnode.next.previous = newnode
        //        step++;

        //    }
        //}

    }
}
