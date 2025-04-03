namespace Eloi.Note
{

public class LinkNoteMono_PayPalMeDonation: LinkNoteMono
{
    private void Reset()
    {
        m_link = new NoteLink.NamedLink("Paypal Me Eloi", "https://www.paypal.me/eloistree");
    }

}

}