using System;
using System.Windows.Forms;

namespace ControlAllTheThings.BoardActions
{
    public class SendTextBoardAction : BoardAction
    {
        public String Text { get; private set; }

        public SendTextBoardAction( String text )
        {
            this.Text = text;
        }

        public override bool RunWhileInitializing
        {
            get { return false; }
        }

        protected override void Perform( BoardInterface b )
        {
            try
            {
                SendKeys.Send( Text );
            }
            catch( InvalidOperationException ) { }
        }

        public override bool Valid( BoardInterface b )
        {
            return !String.IsNullOrEmpty( Text );
        }
    }
}
