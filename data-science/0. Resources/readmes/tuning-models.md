# Tuning Models

After you have evaluated your model on the dataset, you probably have found some areas that you can work on. If you have not, don't worry. Optimizing is an iterative process. Below are some ways you can get started. Note: You don't have to do them all. Just choose the ones that you think are most appropriate for your model.

#### Data Preprocessing and Feature Selection
- You could go back to [preprocessing](https://www.geeksforgeeks.org/data-preprocessing-in-data-mining/) and check to see if you could handle missing values, outliers, and categorical variables more appropriately. Ask yourself if you are dropping any features that might be useful. Maybe, some features need one-hot encoding or scaling. Experiment to see if they make a difference.
- You could also try [feature extraction](https://www.analyticsvidhya.com/blog/2020/12/feature-engineering-using-pandas-for-beginners/) to create new relevant features or transform existing ones. For example, if one of your columns is ```address```, maybe you could extract the postcode and feed it into your model.

#### Hyperparameter Tuning

Machine Learning is like a machine with a lot of knobs. Only by turning each of these knobs a certain way, you get a model to work well. These knobs in question are called hyperparameters. Hyperparameters are parameters that can be set by you to make the model perform in a specific way. There is no set way of finding the best hyperparameters but we can use several heuristics to get closer to more optimal ones.
- For classification, you should try to use [ROC and AUC](https://learn.microsoft.com/en-nz/training/modules/optimize-model-performance-roc-auc/) to get the best threshold for your classification model. 
- The hyperparameters vary from model to model. So it is always a good idea to read the documentation for your model on ```sklearn``` to see what parameters are needed for a particular model. Then, you can find the best hyperparameters by techniques like [grid search](https://scikit-learn.org/stable/modules/generated/sklearn.model_selection.GridSearchCV.html#sklearn.model_selection.GridSearchCV), [random search](https://scikit-learn.org/stable/modules/generated/sklearn.model_selection.RandomizedSearchCV.html), or [parameter grid](https://scikit-learn.org/stable/modules/generated/sklearn.model_selection.ParameterGrid.html#sklearn.model_selection.ParameterGrid). If you are doing Random Forest, you can refer to [this](https://learn.microsoft.com/en-nz/training/modules/machine-learning-architectures-and-hyperparameters/6-hyperparameters). Internet is your friend when it comes to implementing one of these. You could also try to manually change the hyperparameters to improve your model and validating it with cross-fold validation. 

#### Ensemble

Most models in data science competitions use a technique called ensemble. The idea of ensemble is to combine the output of multiple models to create a single output. This way, different models can compensate for each other's weaknesses and give a combined output that is more stable better than the output of single model. There are various ways of ensembling including bagging, boosting, stacking, voting, etc.

The simplest ensemble technique is [voting](https://towardsdatascience.com/creating-an-ensemble-voting-classifier-with-scikit-learn-ab13159662d) where you average the final output if it's regression or find the majority class that if it's classification. You could implement this using the ```ensemble.VotingClassifier``` from [sklearn](https://scikit-learn.org/stable/modules/generated/sklearn.ensemble.VotingClassifier.html). Use this [guide]((https://machinelearningmastery.com/voting-ensembles-with-python/)) to help you get started.








## Optimization

This part is a bit unstructured but you have *complete* freedom on deciding how you could improve your model(s). You could try and evaluate other models. Choose the better performing model from above and improve upon it or combine the two models into one! Refer to [Step 4: Optimizing](https://github.com/NZMSA/2023-Phase-2/tree/main/data-science/2.%20Model%20Training%20and%20Evaluation#step-4-optimizing) for some more options. 

Feel free to be creative here.

Whatever you do, make sure you document what you are doing so that we understand!

At the end, write a short summary (with a graph for brownie points) on how much improvement you have achieved from your base model.

Note: This is your time to shine. Optimization is really what separates an average data scientist from a great one. Make something that you can be proud of. If you achieve that, this notebook can prove to become a great asset to your data science portfolio. As a bare minimum, implement at least one method to improve upon your base model(s).