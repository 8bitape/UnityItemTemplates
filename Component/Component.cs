﻿namespace Components
{
    public class $safeitemname$ : BaseComponent
    {
        protected override void Start()
        {
            base.Start();

            if (!this.IsValid())
            {
                return;
            }

            // Setup subscriptions
        }
    }
}
