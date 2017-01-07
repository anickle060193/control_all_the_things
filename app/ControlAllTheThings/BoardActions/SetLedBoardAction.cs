namespace ControlAllTheThings.BoardActions
{
    class SetLedBoardAction : BoardAction
    {
        public bool SetToState { get; private set; }

        public SetLedBoardAction( bool setToState )
        {
            SetToState = setToState;
        }

        protected override void Perform( BoardInterface b )
        {
            b.SetLed( SetToState );
        }

        public override bool Valid( BoardInterface b )
        {
            return true;
        }
    }
}
