public class DeveloperNote_EthereumDonation : DeveloperNote_Links
{
    private void Reset()
    {
        m_setup.m_links = new LinksClass.Links { m_namedUrls = new LinksClass.NameLink[] { new LinksClass.NameLink("Ethereum Eloi", "https://etherscan.io/address/0xDa3239C8ad5C321A1411F3acC2C1f9F8C9D34ECE") } };
    }
}