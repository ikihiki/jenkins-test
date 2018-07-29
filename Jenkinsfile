pipeline {
  agent any
  stages {
    stage('install') {
      steps {
        dir(path: 'front') {
          sh 'npm install'
        }

      }
    }
    stage('build') {
      steps {
        dir(path: 'front') {
          sh 'npm run tsc'
        }

      }
    }
    stage('test') {
      steps {
        dir(path: 'front') {
          sh 'npm run test'
        }

      }
    }
  }
}