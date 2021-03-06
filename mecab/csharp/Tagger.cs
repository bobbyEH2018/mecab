/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.4
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace MeCab {

using System;
using System.Runtime.InteropServices;

public class Tagger : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Tagger(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(Tagger obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~Tagger() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          MeCabPINVOKE.delete_Tagger(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static bool parse(Model model, Lattice lattice) {
    bool ret = MeCabPINVOKE.Tagger_parse__SWIG_0(Model.getCPtr(model), Lattice.getCPtr(lattice));
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool parse(Lattice lattice) {
    bool ret = MeCabPINVOKE.Tagger_parse__SWIG_1(swigCPtr, Lattice.getCPtr(lattice));
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string parse(string str) {
    string ret = MeCabPINVOKE.Tagger_parse__SWIG_2(swigCPtr, str);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node parseToNode(string str) {
    IntPtr cPtr = MeCabPINVOKE.Tagger_parseToNode(swigCPtr, str);
    Node ret = (cPtr == IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string parseNBest(uint N, string str) {
    string ret = MeCabPINVOKE.Tagger_parseNBest(swigCPtr, N, str);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool parseNBestInit(string str) {
    bool ret = MeCabPINVOKE.Tagger_parseNBestInit(swigCPtr, str);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual Node nextNode() {
    IntPtr cPtr = MeCabPINVOKE.Tagger_nextNode(swigCPtr);
    Node ret = (cPtr == IntPtr.Zero) ? null : new Node(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string next() {
    string ret = MeCabPINVOKE.Tagger_next(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string formatNode(Node node) {
    string ret = MeCabPINVOKE.Tagger_formatNode(swigCPtr, Node.getCPtr(node));
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_request_type(int request_type) {
    MeCabPINVOKE.Tagger_set_request_type(swigCPtr, request_type);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int request_type() {
    int ret = MeCabPINVOKE.Tagger_request_type(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual bool partial() {
    bool ret = MeCabPINVOKE.Tagger_partial(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_partial(bool partial) {
    MeCabPINVOKE.Tagger_set_partial(swigCPtr, partial);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual int lattice_level() {
    int ret = MeCabPINVOKE.Tagger_lattice_level(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_lattice_level(int level) {
    MeCabPINVOKE.Tagger_set_lattice_level(swigCPtr, level);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual bool all_morphs() {
    bool ret = MeCabPINVOKE.Tagger_all_morphs(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void set_all_morphs(bool all_morphs) {
    MeCabPINVOKE.Tagger_set_all_morphs(swigCPtr, all_morphs);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void set_theta(float theta) {
    MeCabPINVOKE.Tagger_set_theta(swigCPtr, theta);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual float theta() {
    float ret = MeCabPINVOKE.Tagger_theta(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual DictionaryInfo dictionary_info() {
    IntPtr cPtr = MeCabPINVOKE.Tagger_dictionary_info(swigCPtr);
    DictionaryInfo ret = (cPtr == IntPtr.Zero) ? null : new DictionaryInfo(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual string what() {
    string ret = MeCabPINVOKE.Tagger_what(swigCPtr);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Tagger create(int argc, SWIGTYPE_p_p_char argv) {
    IntPtr cPtr = MeCabPINVOKE.Tagger_create__SWIG_0(argc, SWIGTYPE_p_p_char.getCPtr(argv));
    Tagger ret = (cPtr == IntPtr.Zero) ? null : new Tagger(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static Tagger create(string arg) {
    IntPtr cPtr = MeCabPINVOKE.Tagger_create__SWIG_1(arg);
    Tagger ret = (cPtr == IntPtr.Zero) ? null : new Tagger(cPtr, false);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public static string version() {
    string ret = MeCabPINVOKE.Tagger_version();
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Tagger(string argc) : this(MeCabPINVOKE.new_Tagger__SWIG_0(argc), true) {
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public Tagger() : this(MeCabPINVOKE.new_Tagger__SWIG_1(), true) {
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string parseToString(string str, uint length) {
    string ret = MeCabPINVOKE.Tagger_parseToString__SWIG_0(swigCPtr, str, length);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string parseToString(string str) {
    string ret = MeCabPINVOKE.Tagger_parseToString__SWIG_1(swigCPtr, str);
    if (MeCabPINVOKE.SWIGPendingException.Pending) throw MeCabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
