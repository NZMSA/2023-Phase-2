# Modelling and Evaluation

Now that you are done with EDAs and preprocessing, you are now ready for the fun part!

The structure of this section is as follows:

  - [Step 0: Splitting the dataset](#step-0-splitting-the-dataset)
  - [Step 1: Choosing a model](#step-1-choosing-a-model)
  - [Step 2: Training and testing](#step-2-training-and-testing)
  - [Step 3: Evaluation](#step-3-model-evaluation)
  - [Step 4: Optimizing](#step-4-optimizing)

The goal of this part is to have:
- Trained models using ```sklearn``` on the dataset that you have chosen.
- Evaluated the model(s) on different metrics and summarising them in your notebook.
- Explained the steps taken to make the model perform better.

You may choose to skip the guide as long as you complete the above.

There are many good notebook examples in [Kaggle](https://www.kaggle.com/competitions?hostSegmentIdFilter=5) that you can take *inspiration* from. You can do this by selecting a dataset, then going to ```Code``` and then choosing among the most voted notebooks. You can learn a lot by reading these notebooks and you can have a good idea of what a good notebook looks like.

## Setup
Before you start, it is highly recommended that you have a virtual environment is set up. Using [anaconda](https://docs.conda.io/en/latest/miniconda.html), this is:
```bash
conda create -n msa python=3.8 -y
conda activate msa
```

Also, install ```sklearn``` if it is not installed yet:
```
pip install -U scikit-learn
```

## Preface
Machine Learning (ML), as the name suggests, is teaching the machine how-to think and not what to think. While this topic and big data has been around for decades, it is becoming more popular than ever because the barrier to entry has become lower with computers doing much of the heavy lifting for the math side of ML. This is both good and bad. It’s good because these algorithms are now accessible to more people that can solve more problems in the real-world. It’s bad because a lower barrier to entry means that more people will not know the tools they are using and can come to incorrect conclusions.

It is vital that you don't just know what to do, but also know why you’re doing it. I like to use the analogy of asking someone to hand you a Philip screwdriver, and they hand you a flathead screwdriver or worst, a hammer. At best, it shows a complete lack of understanding. At worst, it makes completing the project impossible; or even worse, implements a hazardous and harmful operation. So now that I’ve hammered my point (no pun intended), I’ll guide you on what to do and most importantly, *WHY* you should do it.

## Step 0: Splitting the dataset
Our ultimate goal is to use a subset of the data in the real-world to create a useful model that can be used to predict unseen new real-world data. We do this by splitting our dataset into two sets: train and test. We keep the test set untouched during training so that we can use it to evaluate our trained models and get an estimate for how they would perform with new data in the real-world.

Doing the split takes only two lines with ```sklearn```:
```python
from sklearn.model_selection import train_test_split

# Create an 80-20 split on the dataset
X_train, X_test, y_train, y_test = train_test_split(X, y, test_size=0.2, random_state=42)
```
If you are on a notebook, instead of writing the entire thing, you can press ```SHIFT+TAB``` inside the function parameters of ```train_test_split()```. This will make create a popup box showing the function's documenation and you can just copy an example from there into your code space.

## Step 1: Choosing a model
When it comes to data modelling, a beginner's question is always "what is the best ML algorithm to learn?" To this, a beginner must learn the [No Free Lunch Theorem (NFLT)](https://robertmarks.org/Classes/ENGR5358/Papers/NFL_4_Dummies.pdf) of ML. In short, NFLT states that there is no one super algorithm that can achieve the best results in all problems. So the best approach is to try different ML algorithms, tune them and compare them for our specific problem. We can have an intuition on what type of model (or tool from our analogy) can be used by understanding what type of problem we are dealing with. 

In general, there are many machine learning problems, however they can be reduced to four categories: classification, regression, clustering, or dimensionality reduction, depending on your target variable and data modeling goals. We'll save clustering and dimension reduction for another day, and focus on classification and regression for this phase.

As a refresher, the main difference between regression and classification is that regression is about predicting a continuous target variable while classification is about predicting a discrete target variable instead. On a side note, logistic regression, while it has regression in the name, is really a classification algorithm.

Depending on the dataset and the problem you have chosen, you can now choose an appropriate model for it:
```python
from sklearn.linear_model import LogisticRegression

# Load the model (change the RHS to have a different model)
model = LogisticRegression()
```

You can use this [cheatsheet](https://s3.amazonaws.com/assets.datacamp.com/blog_assets/Scikit_Learn_Cheat_Sheet_Python.pdf) to help you get familiar with ```sklearn``` syntax. 

I recommend that you start with a simple algorithm e.g. Linear for regression or Logistic Regressic for classification, and then come back after completing step-5 to evaluate other models and compare the results between them.

## Step 2: Training and testing
Training a model in ```sklearn``` is as easy as:
```python
model.fit(X_train, y_train)
```
However, since each algorithm works differently than others, I insist that you research and understand the algorithm that you are using. In your notebook, you might want to write a brief section in your own words on how you think the algorithm works. This will help you understand what you are doing and help you gain an intuition on different models later on.

To test a model, we pass in the test input and store the predictions:
```python
predictions = model.predict(X_test)
```
Then, for classification, we can get a simple top-1 accuracy through:
```python
from sklearn.metrics import accuracy_score

accuracy = accuracy_score(y_test, predictions)
print(accuracy)
```
If it's a regression problem, we can do a simple Mean Square Error (MSE):
```python
from sklearn.metrics import mean_squared_error

mse = mean_squared_error(y_test, predictions)
print(mse)
```

Now that you know how to train and test different models, try to repeat Step 1 and Step 2 with other models and compare their performances against each other. We will be doing an in-depth evaluation and finetuning on one model, so it's better if we choose the best tool from the start.

Below are some algorithms from the MSLearn modules that you should try.

- Classification
  - Decision Tree
  - Random Forest
  - KNN
  - SVC
  - Perceptron

- Regression
  - Lasso
  - Gradient Boosting Regression
  - Decision Tree Regression
  - Neural Network Regression (Optional)

Refer to sklearn's [modules documentation](https://scikit-learn.org/stable/modules/classes.html) for the different ML algorithms. Some models will need additional parameters when they are initialized. As a goal, try to evaluate at least 3 ML algorithms and create a table to show their accuracies on your dataset.

If you are interested in deep learning, you can complete the [MSLearn Deep Learning Module](https://learn.microsoft.com/en-us/training/modules/train-evaluate-deep-learn-models/) to get more understanding of neural networks.

## Step 3: Model Evaluation

This is where the guide branches off a little bit. I have added two READMEs depending on what type of problem you are doing:

- [Evaluating Classification Models](./evaluating_classification.md)
- [Evaluating Regression Models](./evaluating_regression.md)



### Cross Validation

Many times, models achieve good results during testing but when they get deployed in the real world, they fail in an utterly miserable way. One of the main reasons that this happens is due to overfitting. This means that the model is great at "predicting" data that is has already seen, but terrible at predicting new data, which is not prediction at all. 

Cross Validation is a way to truly get a sense of how a model performs by splitting the dataset $k$ times and then using switching the portion of the data that model trains on and is being tested upon each time. This way, we can avoid any *surprises* that may come up when we test our model in the real-world.

Doing this is a little computationally expensive but ```sklearn``` makes it very simple to implement:

### For Classification Models
```python
from sklearn.model_selection import cross_val_score
from sklearn.model_selection import KFold

# Create a 5-fold cross-validation object
cv = KFold(n_splits=5, shuffle=True, random_state=42)

# Run the cross-validation on the model
scores = cross_val_score(model, X, y, cv=cv)

# Print the scores
print("Cross-Validation Scores:", scores)
```

### For Regression Models
Note for regression models, it is very similar with just an extra parameter for ```cross_val_score``` called scoring to state the metric being used. An example is given below:

```python
# Run the cross-validation on the model with -MSE
scores = cross_val_score(model, X, y, cv=cv, scoring='neg_mean_squared_error')

# Calculate the MSE mean and std
mse_scores = -scores
mean_mse = mse_scores.mean()
std_mse = mse_scores.std()

# Print MSE scores
print("Mean MSE:", mean_mse)
print("Standard Deviation of MSE:", std_mse)
```

Read this [documentation](https://scikit-learn.org/stable/modules/model_evaluation.html) for different ```scoring``` options.


## Step 4: Optimizing
After you have evaluated your model on the dataset, you probably have found out some areas that you can work on. If you have not, don't worry. Optimizing is an iterative process. Below are some ways you can get started. Note: You don't have to do them all. Just choose the ones that you think are most appropriate for your model.

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


## Finishing Up

Now that you have a model that you can be proud of. The only thing left to do is adding comments explanation to your notebook and code so that someone new looking at your notebook can understand what you did. Have a look at some [kaggle dataset](https://www.kaggle.com/code/odins0n/spaceship-titanic-eda-27-different-models) to get an understanding of what good notebooks look like. You might also want to add some graphs at the end to explain any findings that you may have found.
