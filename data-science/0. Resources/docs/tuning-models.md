# Tuning Models

After you have trained, tested, and evaluated your models, you can tune them to further improve their performance. Below are some ways you can get started with tuning.

## Hyperparameter Tuning

Tuning a model generally means tuning the *hyperparameters* of that model. Machine learning models often have various knobs (called hyperparameters) that you can turn one way or another to affect the model's performance on a given dataset. Tuning these hyperparameters just means finding the best value/setting for one or more of the knobs of your model.

Hyperparameters are set by you, the data scientist, based on your intuition or past experience. However, and more often that not, you may not know what values of hyperparameters are best, especially since the best values depend on the underlying algorithm of your model and the data it's been trained on. In that case, there are multiple approaches you can take to find the best hyperparameter values (or at least, as close to the best ones as possible). Before attempting any of the approaches below, read the [Scikit-learn documentation](https://scikit-learn.org/stable/user_guide.html#user-guide) for your model to see what hyperparameters it contains which you can tune.

- [Scikit-learn hyperparameter optimisers](https://scikit-learn.org/stable/modules/classes.html#hyper-parameter-optimizers) (we recommend grid search, randomised search, or parameter grid)
- Manually change the hyperparameters and perform cross-validation yourself (not recommended since Scikit-learn allows you to do this with just one function call, but a valuable learning exercise!)
- Any other approaches from the Microsoft Learn in modules in Phase 1, in particular for classification:
    - [Hyperparameters in classification](https://learn.microsoft.com/en-us/training/modules/machine-learning-architectures-and-hyperparameters/6-hyperparameters)
    - [Measure and optimize model performance with ROC and AUC](https://learn.microsoft.com/en-us/training/modules/optimize-model-performance-roc-auc)


### Cross-validation

The hyperparameter tuning methods available in Scikit-learn use another method called cross-validation. For both classification and regression problems, we can train and test an ML model but oftentimes, models can seem to achieve good results during testing but when they get deployed in the real world, they fail in an utterly miserable way. One of the main reasons that this happens is due to overfitting (i.e. the model is great at predicting using data it has already seen but terrible at predicting using new data). To overcome this, we can use cross-validation beforehand to get a sense of how a model will perform in the real world. This involves splitting the dataset into a certain number of groups (also called folds) and then using each fold of the data to test a model that has been trained on all the other folds.

To ensure that our hyperparameter tuning and cross-validation methodology is valid, we split up our dataset into three sets instead of two: a training set, a validation set, and a test set. Hyperparameter tuning is performed via cross-validation on the training and validation sets, and with the best hyperparameters, the test set is used to assess the performance of the model. 

Note that the test set is not and should not be used within the tuning process, it should only be used as a set of data that our models have never been trained on and so assessing our model against the test set after hyperparameter tuning can provide a better measure of our model's generalisability to unseen data than just using a training and test set alone.

## Other

While not strictly within the realm of "tuning", for the purposes of Phase 2, there are other ways that you can tune your model such as:
- [Feature engineering](https://www.analyticsvidhya.com/blog/2020/12/feature-engineering-using-pandas-for-beginners/) involves creating new features or transforming existing ones. For example, if one of your columns is `address`, you could extract the postcode as another column and feed it into your model.
- [Ensemble methods](https://scikit-learn.org/stable/modules/ensemble.html) (such as bagging, boosting, stacking, and voting) involve combining the output of multiple models to create a single, more robust and stable output, thereby compensating for each model's weaknesses. These methods are commonly used by people developing models in data science competitions - in fact, if you use a random forest for your chosen classification dataset, you're already using ensemble methods! If you would like to try one of the methods mentioned above, we recommend starting with voting using the following links:
    - [Scikit-learn Voting Classifier](https://scikit-learn.org/stable/modules/ensemble.html#voting-classifier)
    - [Creating an Ensemble Voting Classifier with Scikit-learn](https://towardsdatascience.com/creating-an-ensemble-voting-classifier-with-scikit-learn-ab13159662d)
    - [How to Develop Voting Ensembles With Python](https://machinelearningmastery.com/voting-ensembles-with-python)