public class story : helpMenu
{
    public Menu menu;
    public void goNext()
    {
        cur++;
        if (cur == helpList.Length)
        {
            menu.goInGame();
            cur = 0;
        }
    }
}
