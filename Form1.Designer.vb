﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UserControl11 = New WindowsControlGG.UserControl1()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'UserControl11
        '
        Me.UserControl11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UserControl11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserControl11.Elements = 0
        Me.UserControl11.Location = New System.Drawing.Point(12, 12)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(822, 481)
        Me.UserControl11.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(255, 499)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(242, 50)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Сгенерировать новую диаграмму"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 573)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.UserControl11)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Диаграмма"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UserControl11 As WindowsControlGG.UserControl1
    Friend WithEvents Button1 As Button
End Class
