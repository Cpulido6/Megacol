Imports AxZKFPEngXControl
Imports ZKFPEngXControl
Public Class Form1
    Implements ZKFPEngXControl.IZKFPEngXEvents
    Private Captura As ZKFPEngXControl.ZKFPEngX


    Public Sub OnFeatureInfo(AQuality As Integer) Implements IZKFPEngXEvents.OnFeatureInfo

    End Sub

    Public Sub OnImageReceived(ByRef AImageValid As Boolean) Implements IZKFPEngXEvents.OnImageReceived

    End Sub

    Public Sub OnEnroll(ActionResult As Boolean, ATemplate As Object) Implements IZKFPEngXEvents.OnEnroll

    End Sub

    Public Sub OnCapture(ActionResult As Boolean, ATemplate As Object) Implements IZKFPEngXEvents.OnCapture

    End Sub

    Public Sub OnCaptureToFile(ActionResult As Boolean) Implements IZKFPEngXEvents.OnCaptureToFile

    End Sub

    Public Sub OnEnrollToFile(ActionResult As Boolean) Implements IZKFPEngXEvents.OnEnrollToFile

    End Sub

    Public Sub OnFingerTouching() Implements IZKFPEngXEvents.OnFingerTouching

    End Sub

    Public Sub OnFingerLeaving() Implements IZKFPEngXEvents.OnFingerLeaving

    End Sub
End Class
