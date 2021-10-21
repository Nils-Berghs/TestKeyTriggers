# About

This is a sample application for an issue described at https://github.com/microsoft/XamlBehaviorsWpf/issues/93 

Some key things to note
- The sample is a simplification of the real application so let's not discuss setting the application up differently 
- The only reference is XamlBehaviorsWpf
- The application is setup as a single window on which a stack of views is pushed. The stack of corresponding viewmodels is in the MainViewModel
- In the real situation the code is not displayed on screen. 

A very interesting remark (for which I do not have an explanation)
- If the code from the user control and its viewmodel is moved to ViewModelA / TemplateA. The issue does not occur. (It is a user control for reusability).
