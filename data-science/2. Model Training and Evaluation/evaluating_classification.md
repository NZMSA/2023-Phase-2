# Evaluating Classification Models
Now, let's recap. With some basic data cleaning, analysis and ML algorithms, you were able to get a good accuracy. Not bad for a few lines of code. But the question we need to ask now is: Is the model useful and can we do better? 

## Determining a Baseline Accuracy

Let's say you were working on the popular [Titanic Dataset](https://www.kaggle.com/competitions/titanic/overview) and you had to determine if a person onboard survived or not using various information like gender, age, marriage status, salary, etc. And, we wanted to know if our model that has an $80\\%$ accuracy is good or not. How would we do that?

We know that this is a binary classification problem and that there are two outcomes: the passenger survived or died. Similar to a coin flip problem where we have a 50-50 chance of getting right, we could do the same here and set $50\\%$ as the worst model performance. Anything lower, we could trash the model and use a coin instead.

Without any information about the dataset, we can always get a $50\\%$ accuracy with a binary problem. However, what if we had information about the dataset? Let's say from EDA, you know that $1502/2224$ or $67.5\\%$ of people died. So, just by guessing that the person died, we would be right $67.5\\%$ of the time!

## Getting Confusion Matrix

As from above, we can see that accuracy is not always the best metric to use when we have uneven classes.

This can also prove to be very dangerous. What if instead of the titanic dataset, we were dealing with a dataset for a serious disease where only 1/2224 are affected by it?

Getting a 100% accuracy on the model still wouldn't make it useful because it tells us nothing about detecting that one person who has the disease. To analyse our values for True Positives, True Negatives, False Positives and False Negatives, we need to use a confusion matrix.

In ```sklearn```, this is simple:

```python
from sklearn.metrics import confusion_matrix

cm = confusion_matrix(y_test, predictions)
print(cm)
```

As an exercise, try to graph your confusion matrix for your model with labels and axes to make sense of how your model performs on your dataset.

## Getting the F1-score

Going back to the problem at hand, we could use these values to calculate [*Precision* and *Recall*](https://en.wikipedia.org/wiki/Precision_and_recall). 

Remember that, Rec*all* is the number of positive instances predicted correct from *all* instances. Let's say, we want to detect the disease, so ```disease = 1``` and ```no disease = 0```. Here, our recall would be ```disease=1``` over *all*,  which is zero ($0/2224 = 0$). On the other hand, precision is the number of positive instances predicted correct out of all *predicted* positive instances. Here, this is undefined but, we can call it a zero ($0/0+0 = undefined$). Do note that if we had set ```disease = 0``` and ```no disease = 1```, we would have gotten different answers. 

By having both precision and recall being $0$, we can now say for sure that our model is utter garbage at detecting people who do have the disease. 

In general, we use f1-score to combine both precision and recall so that we can get a sense of how well a model is performing.

$$f1 score = 2 * \frac{(precision * recall)}{(precision + recall)}$$

Getting this in ```sklearn``` is as easy as:
```python
from sklearn.metrics import classification_report

cr = classification_report(y_test, predictions)
print(cr)
```

Depending on the problem, we can choose to give more emphasis on precision or recall. For example, here we would have given more emphasis on Precision for ```disease = 1``` because we would certainly not want to diagnose a patient with not having the disease when in reality, they actually have it. 

This directly links to [ROC and AUC curves](https://learn.microsoft.com/en-nz/training/modules/optimize-model-performance-roc-auc/) where we tune our hyperparameters to put emphasis on one or the other, depending on our problem.
