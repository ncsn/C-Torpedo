   M S B A M L   `   `   `  ????G  CTorpedo_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Torpedo_GameTorpedo_Game  5   	       Torpedo_Game.PvsAIWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Torpedo_Game     5   	   -   5          ?Name$  pvsaiWindow??5	   	    ? Title$ Torpedo??5   	   $	??450??6   $	??800??6&    ? WindowStartupLocation$ CenterScreen=?5	       ? 
ResizeMode$ NoResize=?6C   .??5
      ?? ??5   
   ?? 5       ?? ImageSource$ /bg.jpg??6   .+?5   
   ?? $	??309??6   
???????$??48(?6/   $??Bernard MT Condensed)?6=   $??	0,40,0,20q?6_    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .??5      Player versus AI5      ?? 5   
   $	??205??6   $??30??6   $??	0,0,-2,10q?6(   $??0,8,0,0q?6;   $
??Bold"?6M   $??16(?6_   
???????.??6?   Player6?   ?? 5   
   -   5         ??Name$ 
PlayerName??5      $	??189??6&   $??30??62   $??	0,0,-2,40q?6>   6S   ?? 5   
   -   5         ??Name$ 
playButton??5       $
??Play??6    ?? 	ClickMode$ Press=?6M   $	??160??6_   $??30??6k   $??	0,0,-2,15q?6w   $
??Bold"?6?   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6  ???	#FF5A5858$??Stretch=?6-  ?? 5   
   -   5        $ 
backButton??5       $
??Back??6   $ Press=?6M   $	??160??6_   $??30??6k   $??	0,0,-2,10q?6w   $
??Bold"?6?   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6  ???	#FF5A5858$??Stretch=?6-  5      5      