   M S B A M L   `   `   `  ����]  YCandidateManagement_NguyenMinhThuc, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:CandidateManagement_NguyenMinhThuc"CandidateManagement_NguyenMinhThuc  5   	   9    3CandidateManagement_NguyenMinhThuc.JobPostingWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Blocal0clr-namespace:CandidateManagement_NguyenMinhThuc     5   	   -   5          � Title$  Job Posting Screen��5   	   $	��600��6$   $	��800��61   ���#f0f8ff.��5      � $��10q�6   .+�5   
   �� $��JOB POSTING SCREEN��6   $��24(�6.   $
��Bold"�6<   $��Center=�5      ���#4682B461   �� 5   
   $	��Top=�6   $��Center=�6-   $	��500��6J   $��20q�6V   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��10q�62   .+�5      �� $��Posting ID: ��6   $	��100��60   $��Center=�6<   �� 5      -   5        $��txtPostingID��5      $	��300��6.   ���#FFF6:   5      �� 5      $ 
Horizontal=�6   $��10q�62   .+�5      �� $��Title: ��6   $	��100��6+   $��Center=�67   �� 5      -   5        $��txtTitle��5      $	��300��6*   ���#FFF66   5      �� 5       $ 
Horizontal=�6   $��10q�62   .+�5!      �� $��Post Date: ��6   $	��100��6/   $��Center=�6;   (  "System.Windows.Controls.DatePicker  5"      -   5        $��
dpPostDate��5"      $	��300��6/   ���#FFF6;   5#      �� 5&      $ 
Horizontal=�6   $��10q�62   .+�5'      �� $��Description: ��6   $	��100��61   $	��Top=�6=   �� 5(      -   5        $��txtDescription��5(      $	��300��60   $	��100��6<    �� TextWrapping$
 Wrap=�6I    �� AcceptsReturn$
 True��6]   ���#FFF6r   5)      �� 5,      $ 
Horizontal=�6   $��Center=�62   $��20q�6O   .+�5-      �� -   5        $��Create��5-      $��75��6*   $��30��65   $��5q�6A   ���#32CD32
�������6t   �� 5.      -   5        $
��Read��5.      $��75��6(   $��30��63   $��5q�6?   ���#4682B4
�������6r   �� 5/      -   5        $��Update��5/      $��75��6*   $��30��65   $��5q�6A   ���#FFD700
���   �6t   �� 50      -	   5        $��Delete��50      $��75��6*   $��30��65   $��5q�6A   ���#FF4500
�������6t   51      52      &   System.Windows.Controls.DataGrid  55   
   -
   5        $��dataGridJobPostings��55      $��Bottom=�6.   $��10q�6I   $	��200��56      $��Stretch=�6      AutoGenerateColumns$
 True��58      59      5;      5<      