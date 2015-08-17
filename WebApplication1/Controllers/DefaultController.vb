﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class DefaultController
        Inherits Controller

        ' GET: Default
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: Default/Details/5
        Function Details(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' GET: Default/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Default/Create
        <HttpPost()>
        Function Create(ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add insert logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Default/Edit/5
        Function Edit(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Default/Edit/5
        <HttpPost()>
        Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add update logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function

        ' GET: Default/Delete/5
        Function Delete(ByVal id As Integer) As ActionResult
            Return View()
        End Function

        ' POST: Default/Delete/5
        <HttpPost()>
        Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
            Try
                ' TODO: Add delete logic here

                Return RedirectToAction("Index")
            Catch
                Return View()
            End Try
        End Function
    End Class
End Namespace