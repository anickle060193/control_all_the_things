namespace ControlAllTheThings.BoardActions
{
    class TogglePinBoardAction : BoardAction
    {
        public NamedPin Pin { get; private set; }

        public TogglePinBoardAction( NamedPin pin )
        {
            Pin = pin;
        }

        public override bool RunWhileInitializing
        {
            get { return false; }
        }

        protected override void Perform( BoardInterface b )
        {
            b.TogglePin( Pin );
        }

        public override bool Valid( BoardInterface b )
        {
            return b.OutputPins.Contains( Pin );
        }
    }
}
