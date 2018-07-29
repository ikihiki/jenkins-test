pipeline {
  agent any
  stages {
    stage('install') {
      steps {
        sh 'npm install'
      }
    }
    stage('build') {
      parallel {
        stage('build') {
          steps {
            sh 'npm run tsc'
          }
        }
        stage('test') {
          steps {
            sh 'npm run test'
          }
        }
      }
    }
    stage('Finish') {
      steps {
        cleanWs(cleanWhenAborted: true, cleanWhenFailure: true, cleanWhenNotBuilt: true, cleanWhenSuccess: true, cleanWhenUnstable: true, cleanupMatrixParent: true)
      }
    }
  }
}