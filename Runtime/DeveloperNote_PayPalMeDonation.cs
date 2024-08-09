public class DeveloperNote_PayPalMeDonation: DeveloperNote_Links
{
    private void Reset()
    {
        m_setup.m_links = new LinksClass.Links { m_namedUrls = new LinksClass.NameLink[] { new LinksClass.NameLink("Paypal Me Eloi", "https://www.paypal.me/eloistree") } };
    }

}
