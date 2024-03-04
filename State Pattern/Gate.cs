namespace State_Pattern
{
    internal class Gate
    {
        //removing conditions by using polymorphism
        private IGateState _gateState;
        public Gate()
        {
            //the initial state of the gate
            _gateState = new ClosedGateState(this);
        }
        public void Pay()
        {
            //imitating payment process
            Random random = new Random();
            PaymentMock payment = new PaymentMock();
            var result = payment.Pay(random.Next());
            if (result)
                PayOk();
            else
                PayFailed();
        }
        private void PayOk()
        {
            _gateState.PayOk();
        }
        private void PayFailed()
        {
            _gateState.PayFailed();
        }
        public void Enter()
        {
            _gateState.Enter();
        }
        public void ChangeState(IGateState state)
        {
            _gateState = state;
        }

    }
}
