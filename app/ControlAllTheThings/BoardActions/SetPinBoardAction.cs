namespace ControlAllTheThings.BoardActions
{
    class SetPinBoardAction : BoardAction
    {
        public NamedPin Pin { get; private set; }
        public bool SetToState { get; private set; }

        public SetPinBoardAction( NamedPin pin, bool setToState )
        {
            Pin = pin;
            SetToState = setToState;
        }

        protected override void Perform( BoardInterface b )
        {
            b.SetPin( Pin, SetToState );
        }

        public override bool Valid( BoardInterface b )
        {
            return b.OutputPins.Contains( Pin );
        }
    }
}
