namespace LearnWithQB.Server.Config.Contracts
{
    public interface IStripeConfiguration
    {
        string StripePublishableKey { get; }
        string StripeSecretKey { get; }
    }
}