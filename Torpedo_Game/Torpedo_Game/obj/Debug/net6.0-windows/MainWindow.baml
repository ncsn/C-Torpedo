   M S B A M L   `   `   `  ????G  CTorpedo_Game, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Torpedo_GameTorpedo_Game  5   	       Torpedo_Game.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Torpedo_Game     5   	   -   5          ?Name$  
mainWindow??5
   	    ? Title$ Torpedo??5   	   $	??450??6   $	??800??6&    ? WindowStartupLocation$ CenterScreen=?5
       ? 
ResizeMode$ NoResize=?6B   .??5      ?? ??5   
   ?? 5       ?? ImageSource$ /bg.jpg??6    j? Stretch$ UniformToFill=?6/   .+?5   
   ?? $	??241??6   
???????$??72(?6/   $??Bernard MT Condensed)?6=   $??
0,40,0,100q?6_    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      .??5      	Torpedo5      ?? 5   
   -   5        $??
PvsPButton??5   ,   $??Player vs Player??6    ?? 	ClickMode$ Press=?6W   $	??189??6i   $??30??6u   $??	0,0,-2,10q?6?   $
??Bold"?6?   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6  ???	#FF5A5858$??Stretch=?67  ?? 5   
   -   5        $??PvsAIButton??5   (   $??Player vs AI??6   $ Press=?6U   $	??189??6g   $??30??6s   $??	0,0,-2,10q?6   $
??Bold"?6?   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6	  ???	#FF5A5858$??Stretch=?65  ?? 5   
   -   5         ??Name$ scoresButton??5   "   $??Scores??6   $ Press=?6S   $	??189??6e   $??30??6q   $??	0,0,-2,10q?6}   $
??Bold"?6?   
??????????	#FFABABAB$??Arial)?6?   $??14(?6?   $??1,1,3,3q?6?   $
}?True??6  ???	#FF5A5858$??Stretch=?63  5      5      