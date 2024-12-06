# BorderVsFrame

We are told that Frame is now obsolete and to use a Border control. The problem is that a Border reacts differently to how a Frame behaves when it comes to the Tapped gestures.

A Frame would respond to the Tapped gesture recogniser if the user clicked anywhere within the frame, including any border. The Border control will only respond to Tapped if the actual border line is tapped!
