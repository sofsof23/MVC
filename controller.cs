using System;

public class Controller
{
    private Model _model;
    private View _view;

    public Controller(Model model, View view)
    {
        _model = model;
        _view = view;
    }

    public void Run()
    {
        _view.ShowMessage("Welcome to the Counter App! Type: inc / reset / exit");

        while (true)
        {
            string input = Console.ReadLine();
            switch (input.ToLower())
            {
                case "inc":
                    _model.Increment();
                    _view.DisplayCounter(_model.GetCounter());
                    break;
                case "reset":
                    _model.Reset();
                    _view.DisplayCounter(_model.GetCounter());
                    break;
                case "exit":
                    _view.ShowMessage("Exiting app.");
                    return;
                default:
                    _view.ShowMessage("Invalid input.");
                    break;
            }
        }
    }
}
