namespace Eloi.Note
{

public class LinkNoteMono_PayPalMeDonation: LinkNoteMono
{
    private void Reset()
    {
        m_link = new NoteLink.NameLink("Paypal Me Eloi", "https://www.paypal.me/eloistree");
    }

}

}