using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
// 닷넷의 스레드 관련 기능을 제공해 주는 System.Threading 네임 스페이스를 추가.
using System.Windows.Forms.VisualStyles;

namespace ThreadInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThreadInfo_Click(object sender, EventArgs e)
        {
            Thread th = Thread.CurrentThread;
            // Thread 클래스를 이용하여 객체를 선언하되, CurrentThread를 통해 현재 주 스레드 객체를
            // 얻어온다.
            th.Name = "threadInfo";
            // 스레드의 이름 설정.
            tbThreadInfo.Text += "HashCode :" + th.GetHashCode() + "\r\n";
            // 스레드의 해시 코드를 얻어와서 출력한다. 해시 코드란 객체를 식별할 수 있는 하나의 
            // 정수값을 말한다.
            tbThreadInfo.Text += "스레드 이름 :" + th.Name + "\r\n";
            // 스레드의 이름을 출력.
            tbThreadInfo.Text += "스레드 우선순위 :" + th.Priority + "\r\n";
            // 스레드의 우선순위를 출력한다. 스레드가 현재 스케줄러에 있는 큐보다 우선순위가 높은
            // 큐에 들어가면 스케줄러는 우선순위가 높은 큐로 이동하여 스레드를 수행한다.
            // 우선순위에는 크게 실시간, 최상, 보통, 낮음 등이 있다. 디폴트는 보통 이다.
            tbThreadInfo.Text += "스레드 상태 :" + th.ThreadState;
            // 현재 스레드의 상태를 알려 주는 일기 전용 속성이다. 현재 스레드가 동작하고 있는지 멈추었는지
            // 등의 상태 정보를 알려준다.
        }
    }
}
