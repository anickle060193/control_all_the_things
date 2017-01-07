namespace ControlAllTheThings.BoardActions
{
    class TogglePinBoardAction : BoardAction
    {
        public NamedPin Pin { get; private set; }

        public TogglePinBoardAction( NamedPin pin )
        {
            Pin = pin;
        }

        protected override void Perform( BoardInterface b )
        {
            if( !b.Initializing )
            {
                b.TogglePin( Pin );
            }
        }

        public override bool Valid( BoardInterface b )
        {
            return b.OutputPins.Contains( Pin );
        }
    }
}
