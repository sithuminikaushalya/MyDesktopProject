   M S B A M L   `   `   `  ����D  @Dashboard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Dashboard.ViewDashboard.View  5   	   9!clr-namespace:Dashboard.ViewModelDashboard.ViewModel  5   	        Dashboard.View.EditStudent   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Dashboard.View     5   	   7	Viewmodel!clr-namespace:Dashboard.ViewModel     5   	     � WindowStartupLocation$  CenterScreen=�5	   	    � Title$ EditStudent��5
   	   $	��520��6   $	��800��6*    � DataContext 5      .   (Dashboard.ViewModel.EditStudentViewModel  5   
   .��5      � $��	0,0,0,-79q�6   ��5   
   �� 5       �� 
StartPoint$	 0,0&�6"    �� EndPoint$	 1,1&�63   .��5      �  � Color$ 	LightBlue��6    � Offset$	 0.0Q�61   � 5      $ LightSteelBlue��6   $	 1.0Q�66   5      .+�5   
   �� $��20,20,20,54q�6   .+�5      �� $��
First Name��6   
�������6)   �� 5      
���   �$��2q�6i   ��6   �� *	Firstname+ �� UpdateSourceTrigger$ PropertyChanged=�6i   �� 5      $��	Last Name��6   
�������6(   �� 5      
���   �$��2q�6h   ��6   �� *
Lastname+$ PropertyChanged=�6h   �� 5      $��Date of Birth��6   
�������6,   �� 5      
���   �$��2q�6*   ��6>   �� *Dateofbirth+$ PropertyChanged=��� 5      $	��GPA��6   
�������6"   �� 5      
���   �$��2q�6c   ��6   �� *Gpa+$ PropertyChanged=�6c   �� 5      $��Image��6   
�������6$   �� 5       $��Select Image��6   $
��0,10q�6,   
���   �$��2q�6�   
����ح���6:   �� *ChooseImageCommand+$ PropertyChanged=�6�   �� 5!      $	��100��6   $	��100��6!    J� RenderTransformOrigin$ -2.603,0.619&�6k   ��6-   �� *Image+$ PropertyChanged=�6k   5#      �� 5$   
   $��Center=�6   $��	0,424,0,0q�6.   $	��Top=�6A   $��50��6Y   $	��112��6e      	AddButton#��[  6q   ��6�   �� *SubmitCommand+��5%      �� 5&      $	 0,0&�6&   $	 1,1&�67   .��5'      � $ 	LightBlue��6#   $ 0Q�65   � 5(      $ DarkBlue��6#   $ 1Q�64   5)      .��5+      �� $��Submit��6   
�������$��16(�69   5,      5.      5/      