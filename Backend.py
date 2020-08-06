# Load libraries
import sys
import pandas
import cv2
import numpy as np
from pandas.tools.plotting import scatter_matrix
import matplotlib.pyplot as plt
from sklearn import model_selection
from sklearn.metrics import classification_report
from sklearn.metrics import confusion_matrix
from sklearn.metrics import accuracy_score
from sklearn.linear_model import LogisticRegression
from sklearn.tree import DecisionTreeClassifier
from sklearn.neighbors import KNeighborsClassifier
from sklearn.discriminant_analysis import LinearDiscriminantAnalysis
from sklearn.naive_bayes import GaussianNB
from sklearn.svm import SVC
import mahotas as mt
underCount = 0
wellCount = 0
overCount = 0
damageCount = 0
totalBeans = 0
state = 0
while True:
        
        # Load dataset
        df = "caca052.data"
        names = ['blue','green','red','class']
        dataset = pandas.read_csv(df, names=names)

        # shape
        print(dataset.shape)

        # head
        print(dataset.head(20))

        # descriptions
        print(dataset.describe())

        # class distribution
        print(dataset.groupby('class').size())

        # box and whisker plots
        dataset.plot(kind='box', subplots=True, layout=(2,2), sharex=False, sharey=False)
        #plt.show()

        # histograms
        dataset.hist()
        #plt.show()

        # scatter plot matrix
        scatter_matrix(dataset)
        #plt.show()

        # Split-out validation dataset
        array = dataset.values
        X = array[:,0:3]
        Y = array[:,3]
        validation_size = 0.20
        seed = 7
        X_train, X_validation, Y_train, Y_validation = model_selection.train_test_split(X, Y, test_size=validation_size, random_state=seed)
        # Test options and evaluation metric
        seed = 7
        scoring = 'accuracy'
        # Spot Check Algorithms
        models = []
        models.append(('LR', LogisticRegression()))
        #models.append(('LDA', LinearDiscriminantAnalysis()))
        models.append(('KNN', KNeighborsClassifier()))
        models.append(('CART', DecisionTreeClassifier()))
        models.append(('NB', GaussianNB()))
        models.append(('SVM', SVC()))
        # evaluate each model in turn
        results = []
        names = []

        for name, model in models:
                kfold = model_selection.KFold(n_splits=10, random_state=seed)
                cv_results = model_selection.cross_val_score(model, X_train, Y_train, cv=kfold, scoring=scoring)
                results.append(cv_results)
                names.append(name)
                msg = "%s: %f (%f)" % (name, cv_results.mean(), cv_results.std())
                print(msg)

        # Compare Algorithms
        #fig = plt.figure()
        #fig.suptitle('Algorithm Comparison')
        #ax = fig.add_subplot(111)
        #plt.boxplot(results)
        #ax.set_xticklabels(names)
        #plt.show()

        # Make predictions on validation dataset
        knn = KNeighborsClassifier(n_neighbors=1)
        knn.fit(X_train, Y_train)
        predictions = knn.predict(X_validation)
        print(accuracy_score(Y_validation, predictions))
        #print(confusion_matrix(Y_validation, predictions))
        #print(classification_report(Y_validation, predictions))


        #====================================

        #infile="n.txt"
        #with open(infile) as f1:
            #for line in f1:
                #print(line)
                #nombre=line
             
        with open('name'+str(state)+'.txt', 'r') as f:
            f_contents = f.readlines()
        f.close()
        print(f_contents[0])
        #print(f_contents[state])
        #nombre = input(nombre)
        nombre = ""+str(f_contents[0])
        image = cv2.imread(''+str(nombre))
        #print(nombre)
        #print(image)
        blur = cv2.bilateralFilter(image,9,75,75)
        #cv2.imshow('blur',blur)
        #cv2.imwrite('blur.jpg', blur)
        gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
        
        kernel = np.ones((5,5),np.uint8)
        close_operated_image = cv2.morphologyEx(gray, cv2.MORPH_CLOSE, kernel)
        _, thresholded = cv2.threshold(close_operated_image, 0, 255, cv2.THRESH_BINARY_INV + cv2.THRESH_OTSU)

        median = cv2.medianBlur(thresholded, 5)
        #cv2.imshow('median',median)
        #_, contours, _ = cv2.findContours(median, cv2.RETR_TREE, cv2.CHAIN_APPROX_SIMPLE)
        #cv2.drawContours(gray, contours, -1, (100, 0, 255),2)
        dummy = []
        #_, _, angle = cv2.fitEllipse(contour)
        idx =0
        (_,contours,hierarchy)=cv2.findContours(median,cv2.RETR_TREE,cv2.CHAIN_APPROX_SIMPLE)   
        for pic, contour in enumerate(contours):
            area = cv2.contourArea(contour)
            
            if(area>500):
                    
                x,y,w,h = cv2.boundingRect(contour)
                roi=blur[y:y+h,x:x+w]
                roi2=blur[y+7:y+h-7,x+5:x+w-5]
                #cv2.imshow('a' + str(idx), roi2)
                average_color_per_row = np.average(roi, axis=0)
                average_color = np.average(average_color_per_row, axis=0)
                average_color = np.uint8(average_color)
                ave = np.array(average_color).tolist()
                
                #ellipse = cv2.fitEllipse(contour)
                #cv2.ellipse(image,ellipse,(0,255,0),2)
                
                print('a' + str(idx))
                print(average_color)
                print(ave)
                

                """
                hull = cv2.convexHull(contour, returnPoints = False)
                defects = cv2.convexityDefects(contour,hull)

                for i in range(defects.shape[0]):
                        s,e,f,d = defects[i,0]
                        start = tuple(contour[s][0])
                        end = tuple(contour[e][0])
                        far = tuple(contour[f][0])
                        cv2.line(image, start, end, [0,0,255],2)
                        
                        
                """
                
                #textures = mt.features.haralick(roi)
                #ht_mean  = textures.mean(axis=0)
                #ht_mean = ht_mean[3]
                
                #ave.append(ht_mean)
                
                
                #ave.append(ht_mean[2])
                #print(ave)
                
                example_measures = np.array(ave)
                example_measures = example_measures.reshape(1,-1)
                
                prediction = knn.predict(example_measures)
                print(prediction)
                print("................................")

                #cv2.imwrite('c' + str(idx) + '.jpg', roi)
                
                resized = cv2.rectangle(image,(x,y),(x+w,y+h),(0,255,0),2)
                cv2.putText(image, 'a' + str(idx), (x,y),cv2.FONT_HERSHEY_SIMPLEX, 0.7, (255,0,0))
                cv2.putText(image, "" + prediction[0], (x,y+30),cv2.FONT_HERSHEY_SIMPLEX, 0.5, (255,255,255))
                
                if((prediction[0]) == 'Under'):
                        underCount = underCount + 1
                elif ((prediction[0]) == 'Well'):
                        wellCount = wellCount + 1
                elif ((prediction[0]) == 'Over'):
                        overCount == overCount + 1
                
                     
                idx += 1
                
                

               

        #cv2.imshow("image"+str(state), image)
        state = state + 1
        print("Well Fermented: " + str(wellCount))
        print("Under Fermented: " + str(underCount))
        print("Over Fermented: " + str(overCount))
        print("Damage Beans: " + str(damageCount))
        
        if(state>2):
                break
        
                
        

#======================================================
totalBeans = wellCount + underCount + overCount + damageCount
print("Damage Beans: " + str(totalBeans))
print("Done !")
print("Done !")
print("Done !")
file = open("result.txt", "wt")
string = "" +str(wellCount)+ "\n" +str(underCount)+ "\n" +str(overCount) + "\n" +str(damageCount) + "\n" +str(totalBeans)
file.write(string)

file.close()
cv2.waitKey(0)
cv2.destroyAllWindows()





