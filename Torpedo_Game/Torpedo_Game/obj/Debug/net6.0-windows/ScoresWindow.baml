   M S B A M L   `   `   `  ????G  CTorpedo_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Torpedo_GameTorpedo_Game  5   	       Torpedo_Game.ScoresWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Torpedo_Game     5   	   -   5          ?Name$  scoreWindow??5	   	    ? Title$ Torpedo??5   	   $	??750??6   $	??800??6&    J? RenderTransformOrigin$ 0.5,0.5&?5	       ? WindowStartupLocation$ CenterScreen=?6>    ? 
ResizeMode$ NoResize=?6c   .??5
      ?? .??5   
   ?? ??5      ?? 5       ?? ImageSource$ /bg.jpg??6   .+?5      ?? -   5         ??Name$ 
backButton??5   $   $
??Back??6    ?? 	ClickMode$ Press=?6Q   $	??160??6c   $??30??6o   $
??Bold"?6{   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6?   ???	#FF5A5858$
??Left=?6  $??	25,25,0,0q?69  ?? 5      $	??124??6   
???????$??48(?63   $??Bernard MT Condensed)?6A   $??0,0,0,40q?6c   $??Scores??6u    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      ? 5      .+?5      &   System.Windows.Controls.DataGrid  -   5        	  Name$	 table??5   (   $??1??6   
   AutoGenerateColumns$
 False??67      CanUserAddRows$ False??6S      CanUserReorderColumns$ False??6j      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Player??6-      
IsReadOnly$
 True??6=      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6j   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6O   ?? *Player+6j     5      $ Enemy??6-   $
 True??6<   $ * 6h    6N   ?? *Enemy+6h     5      $ Winner??6-   $
 True??6=   $ * 6j    6O   ?? *Winner+6j     5      $ 
PlayerHits??6-   $
 True??6A   $ * 6r    6S   ?? *
PlayerHits+6r     5      $ 	EnemyHits??6-   $
 True??6@   $ * 6p    6R   ?? *	EnemyHits+6p     5      $ Rounds??6-   $
 True??6=   $ * 6j    6O   ?? *Rounds+6j   5      5       5!      5"      5#      