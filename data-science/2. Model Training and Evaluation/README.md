# Modelling and Evaluation

Now that you are done with EDAs and preprocessing, you are now ready for the fun part!

The structure of this section is as follows:

  - [Step 0: Splitting the dataset](#step-0-splitting-the-dataset)
  - [Step 1: Choosing a model](#step0-choose-model)
  - [Step 2: Training and testing](#step2-train-models)
  - [Step 3: Evaluation](#step4-evaluation)
  - [Step 4: Finetuning parameters](#step3-finetune)


Before you start, it is highly recommended that you have a virtual environment is set up. Using [anaconda](https://docs.conda.io/en/latest/miniconda.html):
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
```
For regression, we can do a simple Mean Square Error (MSE):
```python
from sklearn.metrics import mean_squared_error

mse = mean_squared_error(y_test, predictions)
```

Now that you know how to train and test different models, try to repeat Step 1 and Step 2 with other models and compare their performances against each other.

Some algorithms that you could try but are not limited to, include:

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
  - Neural Network Regression (Deep Learning)

Refer to sklearn's [modules](https://scikit-learn.org/stable/modules/classes.html) to import different ML algorithm classes. If you are interested in deep learning, you can complete the [MSLearn Deep Learning Module](https://learn.microsoft.com/en-us/training/modules/train-evaluate-deep-learn-models/) to get more familiar with neural networks.

## Step 3: Model Evaluation


